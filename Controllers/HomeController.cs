using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModel_Fun.Models;

namespace ViewModel_Fun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        string msg = "MESSAGE!";
        return View("Index", msg);
    }

    [HttpGet("/numbers")]
    public IActionResult Numbers()
    {
        int[] num = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9};
        return View(num);
    }

    [HttpGet("/users")]
    public IActionResult Users()
    {
        List<User> users = new List<User>();
        users.Add(new User("This"));
        users.Add(new User("Is", "A"));
        users.Add(new User("Name"));
        users.Add(new User("?"));
        return View(users);
    }

    [HttpGet("/user")]
    public IActionResult OneUser()
    {
        User user = new User("This");
        return View("user", user);
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