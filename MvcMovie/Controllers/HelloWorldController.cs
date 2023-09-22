using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
       // An action method that calls
       // the controller's View method
       // To generate an HTML response by using
       // a view template.
       public IActionResult Index() 
        {
            return View();
        }

        //
        // Olde "Welcome" Method = GET: /HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web

        // New action "Welcome" Method
        // That returns the controller's View method
        // And use the "ViewData" dictionary object
        // That contains data that will be passed to the view. 

        public IActionResult Welcome(string name, int numTimes = 11) 
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
