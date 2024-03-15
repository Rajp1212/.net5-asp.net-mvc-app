using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Proj3_Patel.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Proj3_Patel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<SelectListItem> options = new List<SelectListItem>();
            options.Add(new SelectListItem { Text = "Associate", Value = "Associate", Selected = true });
            options.Add(new SelectListItem { Text = "Bachelor", Value = "Bachelor", });
            options.Add(new SelectListItem { Text = "Masters", Value = "Masters", });
            options.Add(new SelectListItem { Text = "PHD", Value = "PHD", });
            ViewBag.DropDownOptions = options;
            List<SelectListItem> selects = new List<SelectListItem>();
            selects.Add(new SelectListItem { Text = "DePaul", Value = "DePaul", Selected = true });
            selects.Add(new SelectListItem { Text = "UIC", Value = "UIC", });
            selects.Add(new SelectListItem { Text = "UIUC", Value = "UIUC", });
            ViewBag.DropDownOption = selects;
            return View();
        }

        [HttpPost]
        public IActionResult Submit(RegisteredUser userInfo) 
        {
            if(ModelState.IsValid)
            {
                RegisterViewModel model = new RegisterViewModel();
                model.Registration = userInfo;
                model.RegistrationDate = DateTime.Now;
                model.ClientInfo = Request.Headers["User-Agent"].ToString();
                return View(model);
            }
            else
            {
                ErrorViewModel error = new ErrorViewModel();
                error.Message = "You need to enter required field.";
                return View("Error", error);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
