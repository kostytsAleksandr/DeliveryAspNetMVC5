using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Delivery.Data.Contracts;
using Delivery.Data.Repositories;
using Delivery.Domain.Contracts;
using Delivery.Domain.Services;

namespace DeliveryAspNetMVC5.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<ClientsService>().As<IClientsService>();
            builder.RegisterType<ClientsRepository>().As<IClientsRepository>();

            builder.RegisterType<DriversService>().As<IDriversService>();
            builder.RegisterType<DriversRepository>().As<IDriversRepository>();

            builder.RegisterType<ManagersService>().As<IManagersService>();
            builder.RegisterType<ManagersRepository>().As<IManagersRepository>();

            builder.RegisterModule<AutoMapperModule>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}