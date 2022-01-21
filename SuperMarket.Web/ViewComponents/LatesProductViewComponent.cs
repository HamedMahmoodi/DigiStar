using Microsoft.AspNetCore.Mvc;
using SuperMarket.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Web.ViewComponents
{
    public class LatesProductViewComponent:ViewComponent
    {
        private IProductService _productService;
        public LatesProductViewComponent(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("LatesProduct", _productService.GetProduct().Item1));
        }
    }
}
