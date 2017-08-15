using AutoMapper;
using MobileShop.Common.Helper;
using MobileShop.Model.Models;
using MobileShop.Service;
using MobileShop.Web.Infrastructure.Core;
using MobileShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MobileShop.Web.Controllers
{
    public class ProductController : Controller
    {
        #region Initial
        IProductService _productService;
        IProductCategoryService _productCategoryService;

        public ProductController(IProductService productService, IProductCategoryService productCategoryService)
        {
            this._productService = productService;
            this._productCategoryService = productCategoryService;
        }
        #endregion

        // GET: Product
        public ActionResult Detail()
        {
            return View();
        }

        public ActionResult Category(int id,int page=1,string sort="")
        {
            int pageSize = int.Parse(ConfigHelper.GetByKey("PageSize"));
            int totalRow = 0;
            var productModel = _productService.GetListProductByCategoryIdPaging(id, page, pageSize,sort, out totalRow);
            var productViewModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(productModel);
            int totalPage = (int)Math.Ceiling((double)totalRow / pageSize);

            var category = _productCategoryService.GetByID(id);
            ViewBag.Category = Mapper.Map<ProductCategory, ProductCategoryViewModel>(category);
            var paginationSet = new PaginationSet<ProductViewModel>()
            {
                Items = productViewModel,
                MaxPage = int.Parse(ConfigHelper.GetByKey("MaxPage")),
                Page = page,
                TotalCount = totalRow,
                TotalPages = totalPage
            };

            return View(paginationSet);
        }
    }
}