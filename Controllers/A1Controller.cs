using Microsoft.AspNetCore.Mvc;
using A1.Models;
using A1.Data;
using A1.Dtos;

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

        [HttpGet("GetItems")]
        public ActionResult GetItems(String name)
        {
            IEnumerable<Product> products = Repository.GetProductContainingName(name);
            
            return Json(products);
        }

        [HttpGet("GetPhoto")]
        public IActionResult GetPhoto(String id)
        {

            try
            {
                Byte[] b = System.IO.File.ReadAllBytes(@"ItemsImages/" + id + ".jpg");
                return File(b, "image/jpg");
            }

            catch (FileNotFoundException)
            {
                Byte[] b = System.IO.File.ReadAllBytes(@"ItemsImages/default.png");
                return File(b, "image/png");
            }

        }
        //5431456821.gif



        [HttpPost("WriteComments")]
        public ActionResult<CommentDto> WriteComment(CommentDto comment)
        {
            // this method creates an object of the comment class. we use datetime to set time, and httpcontext for ip adress
            Comment c = new Comment {Name = comment.Name, UserComment = comment.UserComment,IP = HttpContext.Connection.RemoteIpAddress.ToString() , Time = DateTime.Now.ToString("yyyy _ MM/dd _ H:mm")};

            // this line adds our previously created object into the database
            Comment AddedComment = Repository.Writecomment(c);

            //this line adds the comment and assign it into a commentDto class, wich we use to return the coment back to the client in the response body
            CommentDto WrittenComment = new CommentDto { Name = AddedComment.Name, UserComment = AddedComment.UserComment };
            return Json(WrittenComment);
        }

        //Get - /api/AllItems
        [HttpGet("GetComments")]
        public ActionResult<CommentDto> GetComments()
        {
            //could not manage to get last 5 items..... so fuction returns all comments
            IEnumerable<Comment> comments = Repository.GetRecentComments();
            return Json(comments);


        }


    }
}