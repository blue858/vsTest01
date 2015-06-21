using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class MYCricketersController : Controller
    {
        //
        // GET: /MYCricketers/
        public ActionResult CricketersIndex()
        {
            return View();
        }

        //// GET: /MYCricketers/         
        //public string Index()         
        //{             
        //    return "Hello this is  My First Controller";         
        //}           
        //public string Welcome()         
        //{             
        //    return "Welcome to My Cricketer Controller";         
        //} 
	}
}