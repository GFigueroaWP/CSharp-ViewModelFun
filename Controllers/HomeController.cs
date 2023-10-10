using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string message = "lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam, voluptatum.";
        return View("Index", message);
    }

    [HttpGet("numbers")]
    public IActionResult Numbers()
    {
        int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        return View(numeros);
    }

    [HttpGet("users")]
    public IActionResult Users()
    {
        List<User> users = new List<User>()
        {
            new User() {Name = "Moose Phillips"},
            new User() {Name = "Sarah"},
            new User() {Name = "Jerry"},
            new User() {Name = "Rene Ricky"},
            new User() {Name = "Barbarah"}
        };
        return View("Users", users);
    }

    [HttpGet("user")]
    public IActionResult User()
    {
        User user = new User() { Name = "Moose Phillips" };
        return View("User", user);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
