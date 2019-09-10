using Microsoft.AspNetCore.Mvc;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {
        #region Home Page
        // Action to view Home Page
        [Route("/")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region Action to redirect to Error page
        // Action to redirect to a Error page
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, the resource you requested could not be found.";
                    break;
            }
            return View("Error");
        }
        #endregion
    }
}