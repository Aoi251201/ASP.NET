using GiaiPT.Models;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GiaiPT.Controllers
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
            return View();
        }
        public IActionResult Ptbac1(string a, string b)
        {
            if (string.IsNullOrEmpty(a))
            {
                ViewBag.Result = "";
            }
            else
            {

                double hsa = Convert.ToDouble(a);
                double hsb = Convert.ToDouble(b);

                if (hsa != 0)
                {
                    ViewBag.Result = $"Phuong trinh co nghiem: x = {-hsb / hsa}";
                }
                else if (hsb == 0 && hsa == 0)
                {
                    ViewBag.Result = "Phuong trinh co vo so nghiem";

                }
                else
                {
                    ViewBag.Result = "Phuong trinh vo  nghiem";

                }

            }
            return View("Ptbac1");
        }

        public IActionResult Ptbac2(string a, string b, string c)
        {

            if (!string.IsNullOrEmpty(a))
            {
                double hsa = Convert.ToDouble(a);
                double hsb = Convert.ToDouble(b);
                double hsc = Convert.ToDouble(c);
                if (hsa == 0)
                {
                    if (hsb == 0 && hsc == 0)
                    {
                        ViewBag.Result = "Phuong trinh co vo so nghiem";
                    }
                    else if (hsb != 0 && hsc != 0)
                    {
                        ViewBag.Result = $"Phuong trinh co 1 nghiem: x = {-hsc / hsb}";
                    }
                    else
                    {
                        ViewBag.Result = "Phuong trinh vo nghiem";
                    }
                }
                else
                {
                    double delta = hsb * hsb - 4 * hsa * hsc;
                    if (delta < 0)
                    {
                        ViewBag.Result = "Phuong trinh vo nghiem";
                    }
                    else if (delta > 0)
                    {
                        ViewBag.Result = "Phuong trinh co 2 nghiem: " +
                            $"x1 = {(-hsb + Math.Sqrt(delta)) / hsa * 2} , " +
                            $"x2 = {(-hsb - Math.Sqrt(delta)) / hsa * 2}";
                    }
                    else
                    {
                        ViewBag.Result = $"Phuong trinh co nghiem kep: x1 = x2 = {-hsb / 2 * hsa}";
                    }
                }
            }
            else
            {
                ViewBag.Result = "";
            }
            return View("Ptbac2");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
