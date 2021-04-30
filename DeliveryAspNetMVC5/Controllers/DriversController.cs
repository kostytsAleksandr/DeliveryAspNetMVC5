
using AutoMapper;
using Delivery.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeliveryAspNetMVC5.Controllers
{
    [Authorize(Roles = "Driver")]
    public class DriversController : Controller
    {
        private readonly IManagersService _managersService;
        private readonly IMapper _mapper;

        public DriversController(IManagersService managersService, IMapper mapper)
        {
            _managersService = managersService;
            _mapper = mapper;
        }
        // GET: Drivers
        public ActionResult Index()
        {
            return View();
        }
    }
}