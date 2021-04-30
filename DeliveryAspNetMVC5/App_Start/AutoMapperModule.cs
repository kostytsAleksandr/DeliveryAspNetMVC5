using Autofac;
using AutoMapper;
using Delivery.Data.Models;
using Delivery.Domain.Models;
using DeliveryAspNetMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeliveryAspNetMVC5.App_Start
{
    public class AutoMapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(context => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CarDeliveryStatusModel, CarDeliveryStatusViewModel>(MemberList.Destination);
                cfg.CreateMap<CarDeliveryStatus, CarDeliveryStatusModel>(MemberList.Destination);
                cfg.CreateMap<ParcelPostModel, ParcelModel>(MemberList.Source);
                cfg.CreateMap<ParcelModel, Parcel>(MemberList.Source);
                cfg.CreateMap<ParcelModel, ParcelViewModel>(MemberList.Destination);
                cfg.CreateMap < IReadOnlyCollection<Parcel>, IReadOnlyCollection < ParcelModel >> (MemberList.Destination);
                cfg.CreateMap<IReadOnlyCollection<ParcelModel>, IReadOnlyCollection<ParcelViewModel>>(MemberList.Destination);
                cfg.CreateMap<ClientModel, ClientViewModel>(MemberList.Source);
                cfg.CreateMap<Client, ClientModel>(MemberList.Destination);
                cfg.CreateMap<ClientModel, ClientViewModel>(MemberList.Destination);
                cfg.CreateMap<Driver, DriverModel>(MemberList.Destination);
                cfg.CreateMap<PostManager, PostManagerModel>(MemberList.Destination);
                cfg.CreateMap<PostManagerModel, PostManagerPostModel>(MemberList.Destination);
            }));

            builder.Register(c =>
            {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();
        }
    }
}