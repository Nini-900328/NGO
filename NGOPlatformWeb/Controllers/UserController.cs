using Microsoft.AspNetCore.Mvc;
// 一般民眾（使用者）相關功能，如註冊、登入、個資編輯等
namespace NGOPlatformWeb.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    public IActionResult CaseActivityList()
        {
            // 之後會改成從資料庫撈，現在先給假資料
            return View(); // View 名稱預設會叫 CaseActivityList.cshtml
        }

        public IActionResult CasePurchaseList()
        {
            return View();
        }
    }
}
