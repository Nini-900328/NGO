<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NGOPlatformWeb.Models.Entity;
using System.Linq;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;
=======
﻿using Microsoft.AspNetCore.Mvc;
using NGOPlatformWeb.Models.Entity;
using System.Linq;
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78

public class ActivityController : Controller
{
    private readonly NGODbContext _context;

    public ActivityController(NGODbContext context)
    {
        _context = context;
    }
<<<<<<< HEAD
    [Authorize(Roles = "Case")]
    public IActionResult CaseActivityIndex(string? category, string? keyword)
    {
        var activities = _context.Activities
         .Where(a => a.TargetAudience == "case");

        if (!string.IsNullOrEmpty(category))
        {
            activities = activities.Where(a => a.Category == category); // 篩分類別
        }

        if (!string.IsNullOrEmpty(keyword))
        {
            activities = activities.Where(a => a.ActivityName.Contains(keyword)); // 模糊搜尋
        }

        return View(activities.ToList());
    }
    [Authorize(Roles = "Case")]
    public IActionResult CaseSignup(int id)
=======

    public IActionResult ActivityIndex()
    {
        var activities = _context.Activities.ToList();
        return View(activities);
    }
    public IActionResult Signup(int id)
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
    {
        var activity = _context.Activities.FirstOrDefault(a => a.ActivityId == id);
        if (activity == null) return NotFound();

        return View(activity);
    }

}
