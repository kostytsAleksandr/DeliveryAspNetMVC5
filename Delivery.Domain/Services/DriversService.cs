using AutoMapper;
using Delivery.Data.Contracts;
using Delivery.Data.Models;
using Delivery.Domain.Contracts;
using Delivery.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Domain.Services
{ 
    public class DriversService : IDriversService
    {
        private readonly IDriversRepository _driversRepository;
        private readonly IMapper _mapper;

        public DriversService(IDriversRepository driversRepository, IMapper mapper)
        {
            _driversRepository = driversRepository;
            _mapper = mapper;
        }

        public Dictionary<int, int> DriverTrips(int driverId)
        {
            return _driversRepository.DriverTrips(driverId);
        }

        public void UpdateDeliveryStatusAfterWay(ParcelModel parcelModel, CarDeliveryStatusModel carDeliveryStatusModel)
        {
            Parcel parcel = _mapper.Map<Parcel>(parcelModel);
            CarDeliveryStatus carDeliveryStatus = _mapper.Map<CarDeliveryStatus>(carDeliveryStatusModel);
            _driversRepository.UpdateDeliveryStatusAfterWay(parcel, carDeliveryStatus);
        }

        public void UpdateDeliveryStatusBeforeWay(ParcelModel parcelModel, CarDeliveryStatusModel carDeliveryStatusModel)
        {
            Parcel parcel = _mapper.Map<Parcel>(parcelModel);
            CarDeliveryStatus carDeliveryStatus = _mapper.Map<CarDeliveryStatus>(carDeliveryStatusModel);
            _driversRepository.UpdateDeliveryStatusBeforeWay(parcel, carDeliveryStatus);
        }
    }
}
