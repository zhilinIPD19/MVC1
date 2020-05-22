using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
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
        public string HelloWorld(string firstName, string lastName)
        {
            return $"Hello World from {firstName} {lastName}!";
        }

        public ActionResult GetUser()
        {

            ViewBag.UserMessage = $"Hello from ";

            List<int> list= new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);


            ViewBag.MyList = list;
            return View();

        }






    }
}