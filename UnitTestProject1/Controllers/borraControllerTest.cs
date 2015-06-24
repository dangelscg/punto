using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using punto;
using punto.Controllers;
//using punto.Models;

namespace punto.Tests.Controllers
{
    [TestClass]
    public class borraControllerTest
    {
        [TestMethod]
        public void index()
        {

           //borraController pu = new borraController();
            PersonaController pu = new PersonaController();
            //pu.Index();
            punto.Models.tbpersona per = new Models.tbpersona()
            { ci="12356",
                estado=1,
                materno="juan",
                paterno="juan",
                nombre="aa",
                fechacreacion=DateTime.Now,
                fechamodificacion=DateTime.Now
            };
 
            ViewResult p = pu.Crear(per) as ViewResult;
            //result.ViewBag.Message
            Assert.AreEqual("uno1",p.ViewBag.otro);
            
           /* punto.Models.tbevento prue = new punto.Models.tbevento();
            prue.titulo = "ssssss";
            var t=ValidationHelper.ValidateEntity<tbevento>(prue);
           // var t=prue.save();*/
            
        }
    }
}
