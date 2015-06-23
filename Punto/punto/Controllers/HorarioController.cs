using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using punto.Models;

namespace punto.Controllers
{
    public class HorarioController : Controller
    {
        //
        // GET: /Horario/
        puntoencuentroEntities db = new puntoencuentroEntities();
        public ActionResult Index()
        {
            return View();
        }

        
        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }
        /// <summary>
        /// agrega un registro a la tabla persona
        /// </summary>
        /// <param name="nuevo">el enviado desde el formulario del cliente</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Crear(tbhorario nuevo)
        {
            // verifica los datos introducidos
            //para trabajar con view
            ViewBag.salida = 0;
            if (ModelState.IsValid)
            {
                db.tbhorario.Add(nuevo);
                int x;
                if ((x = db.SaveChanges()) > 0)
                {
                    ViewBag.salida = x;
                    Redirect("index");
                }
            }

            //mandamos el modelo para que el usuario
            //verifique los errores encontrados
            return View(nuevo);
        }



        [HttpGet]
        public ActionResult editar(int id)
        {

            var conjunto = db.tbhorario.Find(id);
            if (conjunto == null)
                Redirect("index");
            return View(conjunto);
        }
        [HttpPost]
        public ActionResult editar(tbhorario edit)
        {
            ViewBag.salida = 0;
            if (ModelState.IsValid)
            {
                //la mejor forma
                db.Entry<tbhorario>(edit).State = System.Data.EntityState.Modified;
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
