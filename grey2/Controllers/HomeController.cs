using grey2.Data;
using grey2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace grey2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly DataDbContext _login;

        public HomeController(ILogger<HomeController> logger, DataDbContext login)
        {
            _logger = logger;
            _login = login;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Test()
        {
            ViewBag.logins=_login.Login.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult SaveData(Login data)
        {
            try
            {
              
                _login.Login.Remove(data);
                _login.SaveChanges();

                
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Something wrong check db";
            }
            ViewBag.logins = _login.Login.OrderBy(x=>x.uname).ToList();
            return View("Test");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
