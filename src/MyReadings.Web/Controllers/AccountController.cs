using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyReadings.Web.Controllers
{
    public class AccountController : ControllerBase
    {
        public AccountController() { }

        #region GET
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return RedirectToAction("Login");
        }
        //[HttpGet]
        //[AllowAnonymous]
        //public ActionResult Login(string returnUrl)
        //{
        //    //if (User.Identity.IsAuthenticated)
        //    //{
        //    //    return RedirectToAction("Index", "Dashboard");
        //    //}
        //    //ViewBag.ReturnUrl = returnUrl;
        //    //return View();
        //} 
        #endregion
    }
}