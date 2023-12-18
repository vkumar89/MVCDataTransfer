using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MVCDataTransfer.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index1(int? id,string name,double? price)
        {
            ViewData["id"] = id;
            ViewData["name"] = name;
            ViewData["price"]=price;
            return View();
        }
        public ViewResult Display1()
        {
            List<string> color= new List<string>() { "Red", "Blue", "Pink", "Black", "White", "Green", "Brown", "Purple" };
            ViewData["color"]= color;
            return View();
        }

        public ViewResult Index2(int? id,string name,double? price)
        {
            ViewBag.Id = id;
            ViewBag.Name= name;
            ViewBag.Price= price;
            return View();
        }
        public ViewResult Display2()
        {
            List<string> Colors = new List<string>() { "Red", "Blue", "Pink", "Black", "White", "Green", "Brown", "Purple" ,"Red", "Blue", "Pink", "Black", "White", "Green", "Brown", "Purple" ,"Red", "Blue", "Pink", "Black", "White", "Green", "Brown", "Purple" };
            ViewBag.Colors= Colors;
            return View();
        }
        public RedirectToRouteResult Index3(int? Id,string Name,double? price)
        {
            TempData["Id"] = Id;
            ViewBag.name= Name;
            TempData["Price"] = price;
            return RedirectToAction("Index4");
        }
        public ViewResult Index4()
        {
            return View();
        }
        public RedirectToRouteResult Index5(int? id,string name,double? price)
        {
            TempData["Id"] = id;
            TempData["Name"] = name;
            TempData["Price"] = price;
            return RedirectToAction("Index1", "Test");
        }

    }
}