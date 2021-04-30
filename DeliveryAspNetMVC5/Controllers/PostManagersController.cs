using AutoMapper;
using Delivery.Domain.Contracts;
using DeliveryAspNetMVC5.Models;
using DeliveryAspNetMVC5.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeliveryAspNetMVC5.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PostManagersController : Controller
    {
        private readonly IManagersService _managersService;
        private readonly IMapper _mapper;

        public PostManagersController(IManagersService managersService, IMapper mapper)
        {
            _managersService = managersService;
            _mapper = mapper;
        }
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllParcels()
        {
            var allParcels = _managersService.GetAllParselsInfo();
            var allParcelsVm = _mapper.Map<List<ParcelViewModel>>(allParcels);
            var data = new GetParcelsViewModel()
            {
                ParcelViews = allParcelsVm
            };
            return View(data);
        }
        [HttpPost]
        public ActionResult AddCity()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDepartment()
        {
            return View();
        }
        public ActionResult SetDriverForNewparcel()
        {
            var allParcelsWithDrivers = _managersService.SetDriverForNewParcel();
            var allParcelsWithDriversVm = _mapper.Map<List<ParcelViewModel>>(allParcelsWithDrivers);
            var data = new GetParcelsWithDriversViewModel()
            {
                ParcelWithDriverViews = allParcelsWithDriversVm
            };
            return View(data);
        }
    }
}