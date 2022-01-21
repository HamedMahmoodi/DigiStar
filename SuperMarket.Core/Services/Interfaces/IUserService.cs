using SuperMarket.Core.DTOs;
using SuperMarket.DataLayer.Entites.User;
using SuperMarket.DataLayer.Entites.Wallet;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket.Core.Services.Interfaces
{
    public interface IUserService
    {
        #region User

        bool IsExistMobile(string mobile);
        bool IsExistEmail(string email);
        int AddUser(User user);
        User LoginUser(LoginViewModel login);
        User GetUserById(int userId);
        bool ActiveAccount(string activeCode);
        User GetUserByMobile(string mobile);
        void UpdateUser(User user);
        int GetUserIdByMobile(string mobile);
        void DeleteUser(int userId);
        User GetUserByEmail(string email);
        User GetUserByActiveCode(string activeCode);

        #endregion

        #region User Panel

        InformationUserViewModel GetUserInformation(string mobile);
        InformationUserViewModel GetUserInformation(int userId);
        SideBarUserPanelViewModel GetSideBarUserPanelData(string mobile);
        EditProfileViewModel GetDataForEditProfileUser(string mobile);
        void EditProfile(string mobile, EditProfileViewModel profile);
        bool CompareOldPassword(string oldPassword, string mobile);
        void ChangeUserPassword(string mobile, string newPassword);

        #endregion

        #region Wallet

        int BalanceUserWallet(string mobile);
        List<WalletViewModel> GetWalletUser(string mobile);
        int ChargeWallet(string mobile,int amount,string description,bool isPay=false);
        int AddWallet(Wallet wallet);
        Wallet GetWalletByWalletId(int walletId);
        void UpdateWallet(Wallet wallet);

        #endregion

        #region Admin Panel

        UsersForAdminViewModel GetUsers(int pageId = 1, string filterMobile = "");
        UsersForAdminViewModel GetDeleteUsers(int pageId = 1, string filterMobile = "");
        int AddUserFromAdmin(CreateUserViewModel user);
        EditUserViewModel GetUserForShowInEditModel (int userId);
        void EditUserFromAdmin(EditUserViewModel editUser);
        ContactUsForAdminViewModel GetUserContactUs(int pageId = 1, string filterEmail = "", string filterMobile = "");

        #endregion

        #region ContactUs

        int AddContact(ContactUs contact);

        #endregion
    }
}
