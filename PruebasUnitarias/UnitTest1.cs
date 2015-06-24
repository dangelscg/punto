using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using punto.Models;
using punto.Controllers;
using punto;
using System.Web.Mvc;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PersonaController controller = new PersonaController();
            ViewResult salida= controller.Index() as ViewResult;
            
            /*if (salida.ViewBag.imprime == "hola")
            {
                //correcto
            }
            else { 
                //incorrecto
            }*/

            Assert.AreEqual("hola", salida.ViewBag.imprime);
        }
        [TestMethod]
        public void CrearPersona() {
            punto.Models.tbpersona per = new punto.Models.tbpersona()
            { 
                ci="123456",
                estado=1,
                fechacreacion=DateTime.Now,
                fechamodificacion=DateTime.Now,
                fechanac=new DateTime(1990,12,12),
                materno="chulupi",
                paterno="hongo",
                nombre="tulus"
            };
            PersonaController p = new PersonaController();
            ViewResult sa=p.Crear(per) as ViewResult;
            Assert.AreEqual(1, sa.ViewBag.salida);
        }
        [TestMethod]
        public void editarPersona() {
            punto.Models.tbpersona per = new punto.Models.tbpersona()
            {
                idpersona=1,
                ci = "123456",
                estado = 1,
                fechacreacion = DateTime.Now,
                fechamodificacion = DateTime.Now,
                fechanac = new DateTime(1990, 12, 12),
                materno = "chulupi88888888888888",
                paterno = "88888888888hongo",
                nombre = "tulus"
            };
            PersonaController p = new PersonaController();
            ViewResult sa = p.editar(per) as ViewResult;
            Assert.AreEqual(1, sa.ViewBag.salida);
        }
    }
}
