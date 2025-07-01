using Caseshopping0625.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Caseshopping0625.Controllers
{
    public class CaseController : Controller
    {
        //目的：讓 Controller 能透過 DbContext 從資料庫撈資料，給 View 顯示。
        private readonly CaseShoppingContext _context;

        public CaseController(CaseShoppingContext context)
        {
            //這裡使用建構子注入的 _context 是剛剛註冊的 DbContext
            _context = context; 
        }

        public IActionResult ShoppingIndex(string category)
        {
            //var items = _context.CaseShoppingItems.ToList(); // 從資料庫撈
            var items = string.IsNullOrEmpty(category)
                ? _context.CaseShoppingItems.ToList()
                : _context.CaseShoppingItems.Where(x => x.Category == category).ToList();

            return View("ShoppingIndex", items);
        }
    }
}