﻿using HW8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HW8.Controllers
{

    public class PiratesController : Controller
    {
        private PirateUnionContext db = new PirateUnionContext();

        // GET: Pirates
        public ActionResult Index()
        {
            return View(db.Pirates.OrderBy(p => p.FirstName).ToList());
        }

        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var pirate = db.Pirates.Find(id);

            if(pirate == null)
            {
                return HttpNotFound();
            }

            ViewBag.TotalBooty = "$" + pirate.Crews.Sum(b => b.Booty);

            return View(pirate);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Pirate pirate)
        {
            if (ModelState.IsValid && pirate.ConscriptionDate < DateTime.Now)
            {
                db.Pirates.Add(pirate);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            if (pirate.ConscriptionDate > DateTime.Now)
            {
                ViewBag.Error = 1;
                ViewBag.ErrorMessage = "Conscription Date cannot be in the future";
            }

            return View(pirate);
        }
    }
}