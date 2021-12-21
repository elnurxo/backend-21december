using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDayBackEnd.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Content(int id,string name) //ActionResult()
        {
            ViewResult result = new ViewResult();
            result.ViewName = "Content";
            return result;
        }
        public JsonResult Json() //ActionResult()
        {
            var result = new JsonResult(new { name = "Elnur", surname="Khalilov",age=20});
            return result;
        }
        public ViewResult Views()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "View"; //cshtml's name
            return view;
        }
        public ViewResult About() //ActionResult()
        {
            return View(); // if no parametr in View() then it searches for action name, other way searches for our parametr 
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Detail(int id)
        {
            ViewData["Id"] = id;
            ViewBag.Id = 21;
            TempData["Id"] = id;
            return View();
        }
    }
}
