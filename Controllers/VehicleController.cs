using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using stock_taking_system.Models;

namespace stock_taking_system.Controllers
{
    public class VehicleController : Controller
    {
        VehicleDAL vehicleDAL = new VehicleDAL();
        public IActionResult Index()
        {
            List<Vehicles> vhList = new List<Vehicles>();
            vhList = vehicleDAL.GetAllVehicles().ToList();
            return View(vhList);
        }

        //Create 
        [HttpGet]
        public IActionResult Create()
        {
            return View();   
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Vehicles objvh)
        {
            if(ModelState.IsValid)
            {
                vehicleDAL.AddVehicle(objvh);
                return RedirectToAction("Index");
            }
            return View(objvh);
        }

        //Update or Edit Data
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            Vehicles vh = vehicleDAL.GetVehicleID(id);
            if(vh == null)
            {
                return NotFound();
            }
            return View(vh);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, [Bind] Vehicles objvh)
        {
            if (id == null)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                vehicleDAL.UpdateVehicle(objvh);
                return RedirectToAction("Index");
            }
            return View(vehicleDAL);
        }

        //Retrieve Details
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Vehicles vech = vehicleDAL.GetVehicleID(id);
            if (vech == null)
            {
                return NotFound();
            }
            return View(vech);
        }

        //Delete
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Vehicles vech = vehicleDAL.GetVehicleID(id);
            if (vech == null)
            {
                return NotFound();
            }
            return View(vech);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteVehicle(int? id)
        {
            vehicleDAL.DeleteVehicle(id);
            return RedirectToAction("Index");
        }

    }
}
