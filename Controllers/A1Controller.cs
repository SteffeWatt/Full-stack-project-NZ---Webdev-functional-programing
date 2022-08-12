using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using A1.Models;
using A1.Data;
//using A1.Dtos;

namespace A1.Controllers
{

    [ApiController]
    //this string is the path wee need to use when handling traffic (in and out)
    [Route("api")]
    public class A1Controller : Controller
    {
        //sets up a repository variable
        public readonly IA1Repo Repository;


        //creates the controller class and initiates the repository 
        public A1Controller(IA1Repo repository)
        {
            Repository = repository;
        }


        //Get - /api/GetLogo
        [HttpGet("GetLogo")]
        public IActionResult GetLogo()
        {
            Byte[] b = System.IO.File.ReadAllBytes(@"Logos/Logo.png");
            return File(b, "image/png");
        }


        //Get - /api/GetFavIcon 
        [HttpGet("GetFavIcon")]
        public IActionResult GetFavIcon()
        {
            Byte[] b = System.IO.File.ReadAllBytes(@"Logos/Logo-192x192.png");
            return File(b, "image/png");
        }


        //Get - /api/GetVersion
        [HttpGet("GetVersion")]
        public String GetVersion()
        {
            return "1.0.0";
        }


        //Get - /api/AllItems
        [HttpGet("AllItems")]
        public ActionResult GetAllProducts()
        {
            IEnumerable<Product> products = Repository.GetAllProducts();
            return Json(products);

            
        }


    }
}