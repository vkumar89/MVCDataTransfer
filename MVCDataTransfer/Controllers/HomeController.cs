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
        public ViewResult index6(int? id,string Name,double? Price)
        {
            HttpCookie coockie = new HttpCookie("ProductCookie");
            coockie["Id"] = id.ToString();
            coockie["Name"] = Name;
            coockie["Price"] =Price.ToString();
            coockie.Expires = DateTime.Now.AddDays(3);
            Response.Cookies.Add(coockie);
            return View();
        }
        public ViewResult Index7()
        {
            return View();
        }
        public RedirectToRouteResult Index8(int? Id,string Name,Double? price)
        {
            Session["Id"] = Id;
            Session["Name"] = Name;
            Session["Price"] = price;
            return RedirectToAction("Index9");
        }
        public ViewResult Index9()
        {
            return View();
        }
        public RedirectToRouteResult Index10(int? id, string name, double? price)
        {
            Session["Id"] = id;
            Session["Name"] = name;
            Session["Price"] = price;
            return RedirectToAction("Index3", "Test");
        }



    }
}