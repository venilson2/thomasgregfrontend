using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ThomasGregFrontEnd.Models;

namespace ThomasGregFrontEnd.Controllers;

public class ClientController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ClientController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Details()
    {
        return View();
    }
    
    public IActionResult Create()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
