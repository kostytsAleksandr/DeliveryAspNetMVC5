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
    public class ClientsService : IClientsService
    {
        private readonly IClientsRepository _clientsRepository;
        private readonly IMapper _mapper;

        public ClientsService(IClientsRepository clientsRepository, IMapper mapper)
        {
            _clientsRepository = clientsRepository;
            _mapper = mapper;
        }

        public string CreateParcel(ParcelModel model)
        {
            var entity = _mapper.Map<Parcel>(model);
            int countBadParcels = _clientsRepository.GetClientById(entity.ClientWhoSendId).CountBadParcels;
            if (countBadParcels>2)
            {
                return "Sorry, you were blocked, you can't send parcel";
            }
            if (model.Weight >= 200)
            {
                _clientsRepository.AddBadParcel(entity);
                return "Parcel must be less than 200 kg";
            }
            if (model.Costs >= 50000.0m)
            {
                _clientsRepository.AddBadParcel(entity);
                return "Parcel costs must be less than 50000.00$";
            }
            _clientsRepository.CreateParcel(entity);
            return "Parcel has created successfully";
        }

        public IReadOnlyCollection<ClientModel> GetAll()
        {
            var clients = _clientsRepository.GetAll();
            var result = _mapper.Map<IReadOnlyCollection<ClientModel>>(clients);
            return result;
        }

        public ClientModel GetClientById(int id)
        {
            Client client = _clientsRepository.GetClientById(id);
            ClientModel clientModel = _mapper.Map<ClientModel>(client);
            return clientModel;
        }

        public void GetParcel(ParcelModel model)
        {
            Parcel parcel = _clientsRepository.GetParcelById(model.Id);
            _clientsRepository.GetParcel(parcel);
        }

        public ParcelModel GetParcelById(int pacelId)
        {
            Parcel parcel = _clientsRepository.GetParcelById(pacelId);
            ParcelModel parcelModel = _mapper.Map<ParcelModel>(parcel);
            return parcelModel;
        }
    }
}
