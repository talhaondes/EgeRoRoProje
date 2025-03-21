﻿using Business.Concrete;
using Data.Abstract;
using Data.EF;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class FleetController : Controller
    {
        FleetManager fleetManager = new FleetManager(new EfFleetDal());
        public IActionResult Index()
        {
            var getir = fleetManager.FleetGetAll();
            return View(getir);
        }
        public IActionResult Detail(int id)
        {
            var bul = fleetManager.FleetGetById(id); // ID ile getir
            return View(bul);
        }


    }
}
