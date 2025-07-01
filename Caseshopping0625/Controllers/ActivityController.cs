using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Caseshopping0625.Models;
using Microsoft.EntityFrameworkCore;
using ActivityContext = Caseshopping0625.Models.ActivityContext;

public class ActivityController : Controller
{
    private readonly ActivityContext _context;

    public ActivityController(ActivityContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var data = _context.ActivityItem.ToList();
        return View("ActivityIndex",data);
    }

    public IActionResult Signup()
    {
        return View();
    }
}