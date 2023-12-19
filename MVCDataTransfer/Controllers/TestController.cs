using MVCDataTransfer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataTransfer.Controllers
{
    public class TestController:Controller
    {
        public ViewResult Index1()
        {
            return View();
        }
        public ViewResult Display1()
        {
            return View();
        }
        public ViewResult Index2()
        {
            return View();
        }
        public ViewResult Index3()
        {
            return View();
        }
        public ViewResult Display2()
        {
            return View();
        }
        public ViewResult Index4()
        {
            return View();
        } 
        public ViewResult Index5(int? id, string name, double? price)
        {
            var Product = new { Id = id, Name = name, Price = price };
            return View(Product);
        }

        public ViewResult Index6(Product product)
        {
            return View(product);

        }
    }
}