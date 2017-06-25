using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Microsoft.Owin;
using MobileShop.Data.Infrastructure;
using MobileShop.Data.Repositories;
using MobileShop.Service;
using Owin;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

[assembly: OwinStartup(typeof(MobileShop.Web.App_Start.Startup))]

namespace MobileShop.Web.App_Start
{
    public class Startup
    {
        //public void Configuration(IAppBuilder app)
        //{
        //    // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
        //    ConfigAutoface(app);
        //}

        //private void ConfigAutoface(IAppBuilder app)
        //{
        //    var builder = new ContainerBuilder();
        //    //Register your Web Controller
        //    builder.RegisterControllers(Assembly.GetExecutingAssembly());

        //    //Register your Web API controllers.
        //    builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

        //    //Intance UnitOfWork
        //    builder.RegisterType<IUnitOfWork>().As<IUnitOfWork>().InstancePerRequest();

        //    //Intance DbFactory
        //    builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

        //    //Instance DbContext
        //    builder.RegisterType<MobileShopDbContext>().AsSelf().InstancePerRequest();

        //    // Repositories
        //    builder.RegisterAssemblyTypes(typeof(PostCategoryRepository).Assembly)
        //    .Where(t => t.Name.EndsWith("Repository"))
        //    .AsImplementedInterfaces().InstancePerRequest();

        //    //Services
        //    builder.RegisterAssemblyTypes(typeof(PostCategoryService).Assembly)
        //        .Where(t => t.Name.EndsWith("Service"))
        //        .AsImplementedInterfaces().InstancePerRequest();

        //    Autofac.IContainer container = builder.Build();
        //    DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        //    GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
        //}

        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            ConfigAutofac(app);
        }
        private void ConfigAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); //Register WebApi Controllers

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterType<MobileShopDbContext>().AsSelf().InstancePerRequest();

            // Repositories
            builder.RegisterAssemblyTypes(typeof(PostCategoryRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            // Services
            builder.RegisterAssemblyTypes(typeof(PostCategoryService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();

            Autofac.IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container); //Set the WebApi DependencyResolver

        }
    }
}