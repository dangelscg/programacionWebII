using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using punto.Models;

namespace punto.Controllers
{
    public class EventoController: Controller
    {

        
        puntoencuentroEntities db = new puntoencuentroEntities();

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Evento()
        {
            return View();
        }
      
        [HttpPost]
        public ActionResult Evento(tbevento nuevo)
        {
           
            ViewBag.salida = 0;
            if (ModelState.IsValid)
            {
                db.tbevento.Add(nuevo);
                int x;
                if ((x = db.SaveChanges()) > 0)
                {
                    ViewBag.salida = x;
                    Redirect("index");
                }
            }

           
            return View(nuevo);
        }



        [HttpGet]
        public ActionResult editar(int id)
        {

            var conjunto = db.tbevento.Find(id);
            if (conjunto == null)
                Redirect("index");
            return View(conjunto);
        }
        [HttpPost]
        public ActionResult editar(tbevento edit)
        {
            ViewBag.salida = 0;
            if (ModelState.IsValid)
            {
                
                db.Entry<tbevento>(edit).State = System.Data.EntityState.Modified;
                
                int x = db.SaveChanges();
                if (x > 0)
                {
                    ViewBag.salida = x;
                    Redirect("index");
                }
            }
            return View(edit);
        }

    }
}