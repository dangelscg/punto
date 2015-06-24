using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using punto.Models;

namespace punto.Controllers
{
    public class PersonaController : Controller
    {



        //
        // GET: /Persona/
        /// <summary>
        /// agregando el context(el manejado de la base de datos)
        /// </summary>
        puntoencuentroEntities db = new puntoencuentroEntities();

        //
        // GET: /Persona/

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
        public ActionResult Crear(tbpersona nuevo)
        {
            // verifica los datos introducidos
            //para trabajar con view
            ViewBag.salida = 0;
            if (ModelState.IsValid)
            {
                db.tbpersona.Add(nuevo);
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

            var conjunto = db.tbpersona.Find(id);
            if (conjunto == null)
                Redirect("index");
            return View(conjunto);
        }
        [HttpPost]
        public ActionResult editar(tbpersona edit)
        {
            ViewBag.salida = 0;
            if (ModelState.IsValid)
            {
                //la mejor forma
                db.Entry<tbpersona>(edit).State = System.Data.EntityState.Modified;
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

    }
}
