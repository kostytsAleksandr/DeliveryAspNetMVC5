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
    public class ManagersServices : IManagersService
    {
        private readonly IManagersRepository _managersRepository;
        private readonly IMapper _mapper;

        public ManagersServices(IManagersRepository managersRepository, IMapper mapper)
        {
            _managersRepository = managersRepository;
            _mapper = mapper;
        }

        public void CreateCar(CarModel model)
        {
            Car car = _mapper.Map<Car>(model);
            _managersRepository.CreateCar(car);
        }

        public void CreateCarDeliveryStatus(CarDeliveryStatusModel model)
        {
            CarDeliveryStatus carDeliveryStatus = _mapper.Map<CarDeliveryStatus>(model);
            _managersRepository.CreateCarDeliveryStatus(carDeliveryStatus);
        }

        public void CreateCity(CityModel model)
        {
            City city = _mapper.Map<City>(model);
            _managersRepository.CreateCity(city);
        }

        public void CreateDepartment(DepartmentModel model)
        {
            Department department = _mapper.Map<Department>(model);
            _managersRepository.CreateDepartment(department);
        }

        public IReadOnlyCollection<ParcelModel> GetAllParselsInfo()
        {
            IReadOnlyCollection<Parcel> parcels = _managersRepository.GetAllParselsInfo();
            IReadOnlyCollection<ParcelModel> parcelModels = _mapper
                .Map<IReadOnlyCollection<ParcelModel>>(parcels);
            return parcelModels;
        }

        public IReadOnlyCollection<ParcelModel> GetParcelsByDepartmentFrom(int departmentId)
        {
            IReadOnlyCollection<Parcel> parcels = _managersRepository.GetParcelsByDepartmentFrom(departmentId);
            IReadOnlyCollection<ParcelModel> parcelModels = _mapper
                .Map<IReadOnlyCollection<ParcelModel>>(parcels);
            return parcelModels;
        }

        public bool SetDriverForNewParcel(CarDeliveryStatusModel carDeliveryStatusModel, ParcelModel parcelModel)
        {
            CarDeliveryStatus carDeliveryStatus = _mapper.Map<CarDeliveryStatus>(carDeliveryStatusModel);
            Parcel parcel = _mapper.Map<Parcel>(parcelModel);
            return _managersRepository.SetDriverForNewParcel(carDeliveryStatus, parcel);
        }
    }
}
