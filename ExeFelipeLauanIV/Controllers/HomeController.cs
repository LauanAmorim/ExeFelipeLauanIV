using ExeFelipeLauanIV.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeFelipeLauanIV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Cadastrado(Cliente ObjCliente)
        {

            return View(ObjCliente);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Cliente Objcliente)
        {
            if(ModelState.IsValid)
            {
                return View("Cadastrado", Objcliente);
            }
            return View();
        }
        public ActionResult SelectEmail(string Email)
        {
            var dbExeIV = new Collection<string>
            {
                "por1@escola.com",
                "por2@escola.com",
                "por3@escola.com"
            };
            return Json(dbExeIV.All(a => a.ToLower() != Email.ToLower()), JsonRequestBehavior.AllowGet);
        }

        public ActionResult SelectCPF(int CPF)
        {

            var dbExeIV = new Collection<int>
            {
                1112223331,
                1112223332,
                1112223333
            };
            return Json(dbExeIV.All(a => a != CPF), JsonRequestBehavior.AllowGet);
        }
    }
}