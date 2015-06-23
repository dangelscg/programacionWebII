using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using punto.Models;

namespace punto.Controllers
{
    public class TelefonoController : Controller
    {
        //
        // GET: /Telefono/
           puntoencuentroEntities db = new puntoencuentroEntities();
        public ActionResult Index()
        {
            return View();
        }
        public class Lista
        {
            public IEnumerable<SelectListItem> listaLugares { get; set; }
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
        public ActionResult Crear(tbtelefonos nuevo)
        {
            // verifica los datos introducidos
            //para trabajar con view
            ViewBag.salida = 0;
            if (ModelState.IsValid)
            {
                db.tbtelefonos.Add(nuevo);
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

            var conjunto = db.tbtelefonos.Find(id);
            if (conjunto == null)
                Redirect("index");
            return View(conjunto);
        }
        [HttpPost]
        public ActionResult editar(tbtelefonos edit)
        {
            ViewBag.salida = 0;
            if (ModelState.IsValid)
            {
                //la mejor forma
                db.Entry<tbtelefonos>(edit).State = System.Data.EntityState.Modified;
                //la tradicional
                //var da = db.tbpersona.Find(edit.idpersona);
                //da.ci = edit.ci;
                //..
                int x = db.SaveChanges();
                if (x > 0)
                {
                    ViewBag.salida = x;
                    Redirect("index");
                }
            }
            return View(edit);
        }
       
        [HttpGet]
        public ActionResult cargar()
        {
            IList<tblugares> listaLugares = new List<tblugares> { }; 
            int selectedItem=1;
            IEnumerable<SelectListItem>selectList=
                from s in listaLugares
                select new SelectListItem
                {
                Selected=(s.idlugar==selectedItem),
                Text=s.descripcion,
                Value=s.idlugar.ToString()
                };
            Lista lista =new Lista();
            lista.listaLugares=selectList;
             return View(lista);
        }
       


    }
}
