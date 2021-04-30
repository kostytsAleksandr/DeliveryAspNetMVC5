using AutoMapper;
using Delivery.Domain.Contracts;
using Delivery.Domain.Models;
using DeliveryAspNetMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeliveryAspNetMVC5.Controllers
{
    [Authorize]
    public class ClientsController : Controller
    {
        private readonly IClientsService _clientsService;
        private readonly IMapper _mapper;

        public ClientsController(IClientsService clientsService, IMapper mapper)
        {
            _clientsService = clientsService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateParcel(ParcelPostModel model)
        {
            var createModel = _mapper.Map<ParcelModel>(model);
            string message= _clientsService.CreateParcel(createModel);

            return RedirectToAction("Index", "Clients", message);
        }
        public ActionResult InfoAfterAddingParcel(string message)
        {
            ViewData["Message"] = message;
            return View();
        }

        public ActionResult GetParcelInfo()
        {
            return View();
        }

        public ActionResult GetParcel()
        {
            return View();
        }
    }
}