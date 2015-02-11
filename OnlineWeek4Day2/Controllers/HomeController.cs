using OnlineWeek4Day2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineWeek4Day2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Square square = new Square(5, 5);
            return View(square);
        }

        public ActionResult Circle()
        {
            Circle circle = new Circle(7);

            return View(circle);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // "int id = -1" is the same as "var id = id || -1"
        public ActionResult NewPage(int id = -1)
        {
            NewPageViewModel model = new NewPageViewModel();
            model.Shapes = new List<Shape>() {
                new Square(5, 4),
                new Square(7, 3),
                new Circle(9),
                new Circle(13),
                new Square(3, 1),
                new Circle(4),
                new Circle(10),
                new Square(9, 31)
            };
            model.DisplayNum = id;
            return View(model);
        }
    }
}