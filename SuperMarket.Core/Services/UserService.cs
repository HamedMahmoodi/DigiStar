using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SuperMarket.Core.DTOs;
using SuperMarket.Core.Generator;
using SuperMarket.Core.Security;
using SuperMarket.Core.Services.Interfaces;
using SuperMarket.DataLayer.Context;
using SuperMarket.DataLayer.Entites.User;
using SuperMarket.DataLayer.Entites.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperMarket.Core.Services
{
    public class UserService : IUserService
    {
        private SuperMarketContext _context;
        public UserService(SuperMarketContext context)
        {
            _context = context;
        }

        public bool ActiveAccount(string activeCode)
        {
            var user = _context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
            if (user == null || user.IsActive)
                return false;

            user.IsActive = true;
            user.ActiveCode = NameGenerator.GenerateUniqCode();     //کد فعالسازی رو باید یکبار مصر کنیم
            _context.SaveChanges();

            return true;
        }

        public int AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.UserId;
        }

        public User GetUserByMobile(string mobile)
        {
            return _context.Users.SingleOrDefault(u => u.Mobile == mobile);
        }

        public InformationUserViewModel GetUserInformation(string mobile)
        {
            var user = GetUserByMobile(mobile);
            InformationUserViewModel information = new InformationUserViewModel();
            information.Mobile = user.Mobile;
            information.UserName = user.UserName;
            information.Email = user.Email;
            information.RegisterDate = user.RegisterDate;
            information.Wallet = BalanceUserWallet(mobile);

            return information;
        }

        public SideBarUserPanelViewModel GetSideBarUserPanelData(string mobile)
        {
            return _context.Users.Where(u => u.Mobile == mobile).Select(u => new SideBarUserPanelViewModel
            {
                UserName = u.UserName,
                RegisterDate = u.RegisterDate
            }).Single();
        }

        public bool IsExistMobile(string mobile)
        {
            return _context.Users.Any(u => u.Mobile == mobile);
        }

        public User LoginUser(LoginViewModel login)
        {
            string hashPassword = PasswordHelper.EncodePasswordMd5(login.Password);
            string mobile = login.Mobile;
            return _context.Users.SingleOrDefault(u => u.Mobile == mobile && u.Password == hashPassword);
        }

        public EditProfileViewModel GetDataForEditProfileUser(string mobile)
        {
            return _context.Users.Where(u => u.Mobile == mobile).Select(u => new EditProfileViewModel
            {
                UserName = u.UserName,
                Mobile=u.Mobile,
                Email = u.Email,
                Address = u.Address
            }).Single();
        }

        public void EditProfile(string mobile, EditProfileViewModel profile)
        {
            var user = GetUserByMobile(mobile);
            user.UserName = profile.UserName;
            user.Email = profile.Email;
            user.Address = profile.Address;

            UpdateUser(user);
        }

        public void UpdateUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }

        public bool CompareOldPassword(string oldPassword, string mobile)
        {
            string hashOldPassword = PasswordHelper.EncodePasswordMd5(oldPassword);
            return _context.Users.Any(u => u.Mobile == mobile && u.Password == hashOldPassword);
        }

        public void ChangeUserPassword(string mobile, string newPassword)
        {
            var user = GetUserByMobile(mobile);
            user.Password = PasswordHelper.EncodePasswordMd5(newPassword);
            UpdateUser(user);
        }

        public int BalanceUserWallet(string mobile)
        {
            int userId = GetUserIdByMobile(mobile);
            var enter = _context.Wallets.Where(w => w.UserId == userId && w.TypeId == 1 && w.IsPay).Select(w => w.Amount).ToList();
            var exit = _context.Wallets.Where(w => w.UserId == userId && w.TypeId == 2).Select(w => w.Amount).ToList();

            return (enter.Sum() - exit.Sum());
        }

        public int GetUserIdByMobile(string mobile)
        {
            return _context.Users.Single(u => u.Mobile == mobile).UserId;
        }

        public List<WalletViewModel> GetWalletUser(string mobile)
        {
            int userId = GetUserIdByMobile(mobile);
            return _context.Wallets.Where(w => w.IsPay && w.UserId == userId)
                .Select(w => new WalletViewModel()
                {
                    Amount = w.Amount,
                    DateTime = w.CreateDate,
                    Description = w.Description,
                    Type = w.TypeId
                }).ToList();
        }

        public int ChargeWallet(string mobile, int amount, string description, bool isPay = false)
        {
            Wallet wallet = new Wallet()
            {
                Amount = amount,
                CreateDate = DateTime.Now,
                Description = description,
                IsPay = isPay,
                TypeId = 1,
                UserId = GetUserIdByMobile(mobile)
            };
            return AddWallet(wallet);
        }

        public int AddWallet(Wallet wallet)
        {
            _context.Wallets.Add(wallet);
            _context.SaveChanges();
            return wallet.WalletId;
        }

        public Wallet GetWalletByWalletId(int walletId)
        {
            return _context.Wallets.Find(walletId);
        }

        public void UpdateWallet(Wallet wallet)
        {
            _context.Wallets.Update(wallet);
            _context.SaveChanges();
        }

        public UsersForAdminViewModel GetUsers(int pageId = 1, string filterMobile = "")
        {
            IQueryable<User> result = _context.Users;

            if (!string.IsNullOrEmpty(filterMobile))
            {
                result = result.Where(u => u.Mobile.Contains(filterMobile));
            }

            //Show Item In Page
            int take = 20;
            int skip = (pageId - 1) * take;

            UsersForAdminViewModel list = new UsersForAdminViewModel();
            list.CurrentPage = pageId;
            list.PageCount = result.Count() / take;
            list.Users = result.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList();
            return list;
        }

        public int AddUserFromAdmin(CreateUserViewModel user)
        {
            User addUser = new User();
            addUser.Password = PasswordHelper.EncodePasswordMd5(user.Password);
            addUser.ActiveCode = NameGenerator.GenerateUniqCode();
            addUser.Mobile = user.Mobile;
            addUser.Email = user.Email;
            addUser.State = user.State;
            addUser.City = user.City;
            addUser.Address = user.Address;
            addUser.IsActive = true;
            addUser.RegisterDate = DateTime.Now;
            addUser.UserName = user.UserName;
            addUser.IsAdmin = user.IsAdmin;

            return AddUser(addUser);
        }

        public EditUserViewModel GetUserForShowInEditModel (int userId)
        {
            return _context.Users.Where(u => u.UserId == userId)
                .Select(u => new EditUserViewModel()
                {
                    UserId = u.UserId,
                    UserName = u.UserName,
                    Address = u.Address,
                    City = u.City,
                    Email = u.Email,
                    Mobile = u.Mobile,
                    State = u.State,
                    IsAdmin=u.IsAdmin
                }).Single();
        }

        public void EditUserFromAdmin(EditUserViewModel editUser)
        {
            User user = GetUserById(editUser.UserId);
            user.UserName = editUser.UserName;
            user.Address = editUser.Address;
            user.City = editUser.City;
            user.Email = editUser.Email;
            user.State = editUser.State;
            user.IsAdmin = editUser.IsAdmin;
            if (!string.IsNullOrEmpty(editUser.Password))
            {
                user.Password = PasswordHelper.EncodePasswordMd5(editUser.Password);
            }
            _context.Users.Update(user);
            _context.SaveChanges();
        }


        public User GetUserById(int userId)
        {
            return _context.Users.Find(userId);
        }

        public UsersForAdminViewModel GetDeleteUsers(int pageId = 1, string filterMobile = "")
        {
            IQueryable<User> result = _context.Users.IgnoreQueryFilters().Where(u=>u.IsDelete);

            if (!string.IsNullOrEmpty(filterMobile))
            {
                result = result.Where(u => u.Mobile.Contains(filterMobile));
            }

            //Show Item In Page
            int take = 20;
            int skip = (pageId - 1) * take;

            UsersForAdminViewModel list = new UsersForAdminViewModel();
            list.CurrentPage = pageId;
            list.PageCount = result.Count() / take;
            list.Users = result.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList();
            return list;
        }

        public void DeleteUser(int userId)
        {
            User user = GetUserById(userId);
            user.IsDelete = true;
            UpdateUser(user);
        }

        public InformationUserViewModel GetUserInformation(int userId)
        {
            var user = GetUserById(userId);
            InformationUserViewModel information = new InformationUserViewModel();
            information.Mobile = user.Mobile;
            information.UserName = user.UserName;
            information.Email = user.Email;
            information.RegisterDate = user.RegisterDate;
            information.Wallet = BalanceUserWallet(user.Mobile);

            return information;
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.SingleOrDefault(u => u.Email == email);
        }

        public User GetUserByActiveCode(string activeCode)
        {
            return _context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
        }

        public int AddContact(ContactUs contact)
        {
            _context.ContactUs.Add(contact);
            _context.SaveChanges();
            return contact.ContactId;
        }

        public ContactUsForAdminViewModel GetUserContactUs(int pageId = 1, string filterEmail = "", string filterMobile = "")
        {
            IQueryable<ContactUs> result = _context.ContactUs;

            if (!string.IsNullOrEmpty(filterMobile))
            {
                result = result.Where(u => u.Mobile.Contains(filterMobile));
            }
            if (!string.IsNullOrEmpty(filterEmail))
            {
                result = result.Where(u => u.Email.Contains(filterEmail));
            }

            //Show Item In Page
            int take = 20;
            int skip = (pageId - 1) * take;

            ContactUsForAdminViewModel list = new ContactUsForAdminViewModel();
            list.CurrentPage = pageId;
            list.PageCount = result.Count() / take;
            list.ContactUses = result.OrderBy(u => u.CreateDate).Skip(skip).Take(take).ToList();
            return list;
        }

        public bool IsExistEmail(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }
    }
}
