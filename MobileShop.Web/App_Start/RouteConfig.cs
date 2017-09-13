﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MobileShop.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Search",
                url: "tim-kiem.html",
                defaults: new { controller = "Product", action = "Search", id = UrlParameter.Optional },
                namespaces: new string[] { "TeduShop.Web.Controllers" }
            );

            routes.MapRoute(
                name: "Home",
                url: "trang-chu.html",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "MobileShop.Web.Controllers" }
            );

            routes.MapRoute(
                name: "login",
                url: "dang-nhap.html",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional },
                namespaces: new string[] { "MobileShop.Web.Controllers" }
            );

            routes.MapRoute(
                name: "Page",
                url: "trang/{alias}.html",
                defaults: new { controller = "Page", action = "Index", alias = UrlParameter.Optional },
                namespaces: new string[] { "MobileShop.Web.Controller" }

                );

            routes.MapRoute(
             name: "Product",
             url: "{alias}.p-{productId}.html",
             defaults: new { controller = "Product", action = "Detail", productId = UrlParameter.Optional },
               namespaces: new string[] { "TeduShop.Web.Controllers" }
            );

            routes.MapRoute(
                name: "product category",
                url: "{alias}.pc-{id}.html",
                defaults: new { controller = "Product", action = "Category", id = UrlParameter.Optional },
                namespaces: new string[] { "MobileShop.Web.Controllers" }
                );
            routes.MapRoute(
                 name: "TagList",
                 url: "tag/{tagId}.html",
                 defaults: new { controller = "Product", action = "ListByTag", tagId = UrlParameter.Optional },
                   namespaces: new string[] { "TeduShop.Web.Controllers" }
             );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "MobileShop.Web.Controllers" }
            );
        }
    }
}
