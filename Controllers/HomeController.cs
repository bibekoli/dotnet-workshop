using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var list = new List<HomeVm> () {
            new HomeVm { Id = 1, Name = "One", Address = "Address One" },
            new HomeVm { Id = 2, Name = "Two", Address = "Address Two" }
        };
        return View(list);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Form()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
