using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWord.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Logar()
        {
            ViewBag.Msg = "Dados Inválidos";

            //exemplo, se eu quiser ir para outro lugar, vai para Index
            return View("Index");
        }


    }
}