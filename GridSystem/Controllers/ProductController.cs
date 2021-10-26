using GridSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GridSystem.Controllers
{
    public class ProductController : Controller
    {
        public ApplicationContext Context { get; }
        public ProductController(ApplicationContext context)
        {
            Context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

       public IActionResult Category()
        {
            return View();


        }
        public IActionResult AddCategory(Category cat)
        {
            Context.Categories.Add(cat);
            Context.SaveChanges();
            return Json(cat);
        }
    

        public IActionResult GetProducts()
        {
            var products = Context.Products.ToList();      
            return Json(products);
        }
        public IActionResult PostProducts(Product product)
        {
            Context.Products.Add(product);
            Context.SaveChanges();
            return Json(product);
        }

    }
}
