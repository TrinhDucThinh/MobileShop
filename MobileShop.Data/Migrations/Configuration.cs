﻿namespace MobileShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MobileShop.Data.MobileShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MobileShopDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //Create user sample
            // CreateUser(context);
            // CreateProductCategorySample(context);
            CreatePage(context);
            CreateSilde(context);

        }

        private void CreateUser(MobileShopDbContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new MobileShopDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new MobileShopDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "thinh",
                Email = "thinhtd2401@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "Trịnh Đức Thịnh"

            };

            manager.Create(user, "123456$");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("thinhtd2401@gmail.com");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
        private void CreateProductCategorySample(MobileShopDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory() { Name="Điện lạnh",Alias="dien-lanh",Status=true },
                 new ProductCategory() { Name="Viễn thông",Alias="vien-thong",Status=true },
                  new ProductCategory() { Name="Đồ gia dụng",Alias="do-gia-dung",Status=true },
                   new ProductCategory() { Name="Mỹ phẩm",Alias="my-pham",Status=true }
            };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }

        }
        private void CreateSilde(MobileShopDbContext context)
        {
            if (context.Slides.Count() == 0)
            {
                List<Slide> listSlide = new List<Slide>()
                {
                    new Slide()
                    {
                        Name="Slide 1",
                        DisplayOrder=1,
                        Status=true,
                        Url="#",
                        Image="/Assets/client/images/bag.jpg",
                        Content=@"
                        <h2>FLAT 50% 0FF</h2>
                                <label>FOR ALL PURCHASE <b>VALUE</b></label>
                                <p>Lorem ipsum dolor sit amet, consectetur 
                            adipisicing elit, sed do eiusmod tempor incididunt ut labore et </ p >
                        <span class=""on-get"">GET NOW</span>
                        ",
                    },
                     new Slide() {
                        Name ="Slide 2",
                        DisplayOrder =2,
                        Status =true,
                        Url ="#",
                        Image ="/Assets/client/images/bag1.jpg",
                        Content=@"<h2>FLAT 50% 0FF</h2>
                                <label>FOR ALL PURCHASE <b>VALUE</b></label>

                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et </ p >

                                <span class=""on-get"">GET NOW</span>"}
                };
                context.Slides.AddRange(listSlide);
                context.SaveChanges();
            }
        }
        private void CreatePage(MobileShopDbContext context)
        {
            try
            {
                var page = new Page()
                {
                    Name = "Giới thiệu",
                    Alias = "gioi-thieu",
                    Content = @"Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium ",
                    Status = true

                };
                context.Pages.Add(page);
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach(var eve in ex.EntityValidationErrors)
                {
                    Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation error.");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Trace.WriteLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                    }
                }
            }
        }
    }
}
