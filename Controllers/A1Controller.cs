using Microsoft.AspNetCore.Mvc;
[ApiController]
//this string is the path wee need to use when handling traffic (in and out)
[Route("api")]

public class A1Controller : Controller
{

    [HttpGet("GetLogo")]
    public IActionResult GetLogo()
    {
        Byte[] b = System.IO.File.ReadAllBytes(@"Logos/Logo.png");       
        return File(b, "image/png");
    }

    //this method returns a Favicon 
    [HttpGet("GetFavIcon")]
    public IActionResult GetFavIcon()
    {
        Byte[] b = System.IO.File.ReadAllBytes(@"Logos/Logo-192x192.png");
        return File(b, "image/png");
    }

    [HttpGet("GetVersion")]
    public String GetVersion()
    {
        return "1.0.0";
    }


}