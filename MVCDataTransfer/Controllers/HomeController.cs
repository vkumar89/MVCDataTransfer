using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDataTransfer.Models;
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
        public ViewResult Index11(int? id,string Name,double? Price)
        {
            System.Web.HttpContext.Current.Application.Lock();
            System.Web.HttpContext.Current.Application["Id"]=id;
            System.Web.HttpContext.Current.Application["Name"]=Name;
            System.Web.HttpContext.Current.Application["Price"]=Price;
            System.Web.HttpContext.Current.Application.UnLock();

            return View();
        }
        public ViewResult Index12()
        {
            return View();
        }
        public ViewResult Index13(int? id,string name,double? price)
        {
            var product= new {Id=id,Name=name,Price=price};
            return View(product);
        }

        public RedirectToRouteResult Index14(int? id, string name, double? price)
        {
            var Product =new {Id=id,Name=name,Price=price};

           return RedirectToAction("Index5","Test", Product);

        }

        public ViewResult Index15(int? id,string name,double? price)
        {
            Product product = new Product { Id = id, Name = name, Price = price };
            return View(product);
        }
        public RedirectToRouteResult Index16(Product product)
        {
            return RedirectToAction("Index6","Test",product);
        }

    }
}