using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NGOPlatformWeb.Models;

namespace NGOPlatformWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
<<<<<<< HEAD
                // è¼ªæ’­åœ–æ•¸æ“š
                CarouselItems = GetCarouselItems(),

                // åŠŸèƒ½å¡ç‰‡æ•¸æ“š
                FeatureCards = GetFeatureCards(),

                // æ–°æ¶ˆæ¯æ•¸æ“š
                NewsItems = GetNewsItems(),

                // æ´»å‹•æ¬Šè­‰æ•¸æ“š
=======
                // ½ü¼½¹Ï¼Æ¾Ú
                CarouselItems = GetCarouselItems(),

                // ¥\¯à¥d¤ù¼Æ¾Ú
                FeatureCards = GetFeatureCards(),

                // ·s®ø®§¼Æ¾Ú
                NewsItems = GetNewsItems(),

                // ¬¡°ÊÅvÃÒ¼Æ¾Ú
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
                ActivityInfo = GetActivityInfo()
            };

            return View(model);
        }

        public IActionResult Contact()
        {
<<<<<<< HEAD
            ViewData["Title"] = "é€™è£¡æ˜¯è¯çµ¡æˆ‘å€‘";
            return View(); // è¯çµ¡æˆ‘å€‘
=======
            ViewData["Title"] = "³o¸Ì¬OÁpµ¸§Ú­Ì";
            return View(); // Ápµ¸§Ú­Ì
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
        }

        public IActionResult Organization()
        {
<<<<<<< HEAD
            ViewData["Title"] = "é€™è£¡æ˜¯çµ„ç¹”ä»‹ç´¹";
            return View(); // çµ„ç¹”ä»‹ç´¹
        }
        // æ¨¡æ“¬æ•¸æ“šæ–¹æ³•
=======
            ViewData["Title"] = "³o¸Ì¬O²ÕÂ´¤¶²Ð";
            return View(); // ²ÕÂ´¤¶²Ð
        }
        // ¼ÒÀÀ¼Æ¾Ú¤èªk
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
        private List<CarouselItem> GetCarouselItems()
        {
            return new List<CarouselItem>
    {
        new CarouselItem
        {
            ImageUrl = "https://images.unsplash.com/photo-1559027615-cd4628902d4a?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1000&q=80",
<<<<<<< HEAD
            Title = "æ­¡è¿Žä¾†åˆ°NGOç‰©è³‡å¹³å°",
            Description = "é€£çµNGOçµ„ç¹”èˆ‡è³‡æºï¼Œå…±å‰µç¾Žå¥½ç¤¾æœƒ"
=======
            Title = "Åwªï¨Ó¨ìNGOª«¸ê¥­¥x",
            Description = "³sµ²NGO²ÕÂ´»P¸ê·½¡A¦@³Ð¬ü¦nªÀ·|"
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
        },
        new CarouselItem
        {
            ImageUrl = "https://images.unsplash.com/photo-1582213782179-e0d53f98f2ca?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1000&q=80",
<<<<<<< HEAD
            Title = "å°ˆæ¥­ç¤¾å·¥åŸ¹è¨“èª²ç¨‹",
            Description = "æå‡å°ˆæ¥­æŠ€èƒ½ï¼Œæœå‹™ç¤¾æœƒå¤§çœ¾"
=======
            Title = "±M·~ªÀ¤u°ö°V½Òµ{",
            Description = "´£¤É±M·~§Þ¯à¡AªA°ÈªÀ·|¤j²³"
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
        },
        new CarouselItem
        {
            ImageUrl = "https://images.unsplash.com/photo-1469571486292-0ba58a3f068b?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1000&q=80",
<<<<<<< HEAD
            Title = "å¿—å·¥æ‹›å‹Ÿä¸­",
            Description = "åŠ å…¥æˆ‘å€‘ï¼Œä¸€èµ·ç‚ºç¤¾æœƒè²¢ç»åŠ›é‡"
=======
            Title = "§Ó¤u©Û¶Ò¤¤",
            Description = "¥[¤J§Ú­Ì¡A¤@°_¬°ªÀ·|°^Äm¤O¶q"
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
        }
    };
        }

        private List<FeatureCard> GetFeatureCards()
        {
            return new List<FeatureCard>
    {
        new FeatureCard
        {
<<<<<<< HEAD
            Title = "å ±åè­‰ç…§",
            Description = "å°ˆæ¥­è­‰ç…§èª²ç¨‹å ±åèˆ‡ç®¡ç†",
=======
            Title = "³ø¦WÃÒ·Ó",
            Description = "±M·~ÃÒ·Ó½Òµ{³ø¦W»PºÞ²z",
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
            IconUrl = "/images/icon1.png"
        },
        new FeatureCard
        {
<<<<<<< HEAD
            Title = "æ´»å‹•ç®¡ç†",
            Description = "å¿—å·¥æ´»å‹•èˆ‡ç¤¾å€æœå‹™",
=======
            Title = "¬¡°ÊºÞ²z",
            Description = "§Ó¤u¬¡°Ê»PªÀ°ÏªA°È",
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
            IconUrl = "/images/icon2.png"
        },
        new FeatureCard
        {
<<<<<<< HEAD
            Title = "çµ„ç¹”ä»‹ç´¹",
            Description = "äº†è§£å„NGOçµ„ç¹”è³‡è¨Š",
=======
            Title = "²ÕÂ´¤¶²Ð",
            Description = "¤F¸Ñ¦UNGO²ÕÂ´¸ê°T",
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
            IconUrl = "/images/icon3.png"
        },
        new FeatureCard
        {
<<<<<<< HEAD
            Title = "æ™ºåº«è³‡æ–™",
            Description = "å°ˆæ¥­çŸ¥è­˜èˆ‡è³‡æºåˆ†äº«",
=======
            Title = "´¼®w¸ê®Æ",
            Description = "±M·~ª¾ÃÑ»P¸ê·½¤À¨É",
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
            IconUrl = "/images/icon4.png"
        }
    };
        }

        private List<NewsItem> GetNewsItems()
        {
            return new List<NewsItem>
    {
        new NewsItem
        {
<<<<<<< HEAD
            Title = "2024å¹´ç¤¾å·¥å°ˆæ¥­èªè­‰é–‹å§‹å ±å",
            Date = DateTime.Now.AddDays(-1),
            Content = "å³æ—¥èµ·é–‹æ”¾å ±åï¼Œåé¡æœ‰é™è«‹æŠŠæ¡æ©Ÿæœƒ"
        },
        new NewsItem
        {
            Title = "æ–°å¢žç·šä¸Šèª²ç¨‹åŠŸèƒ½",
            Date = DateTime.Now.AddDays(-2),
            Content = "ç¾åœ¨å¯ä»¥é€éŽç·šä¸Šæ–¹å¼åƒèˆ‡èª²ç¨‹å­¸ç¿’"
=======
            Title = "2024¦~ªÀ¤u±M·~»{ÃÒ¶}©l³ø¦W",
            Date = DateTime.Now.AddDays(-1),
            Content = "§Y¤é°_¶}©ñ³ø¦W¡A¦WÃB¦³­­½Ð§â´¤¾÷·|"
        },
        new NewsItem
        {
            Title = "·s¼W½u¤W½Òµ{¥\¯à",
            Date = DateTime.Now.AddDays(-2),
            Content = "²{¦b¥i¥H³z¹L½u¤W¤è¦¡°Ñ»P½Òµ{¾Ç²ß"
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
        }
    };
        }

        private ActivityInfo GetActivityInfo()
        {
            return new ActivityInfo
            {
<<<<<<< HEAD
                Title = "æ´»å‹•æ¬Šè­‰",
                Description = "åƒèˆ‡ç¤¾å€æœå‹™æ´»å‹•ï¼Œç²å¾—æœå‹™æ™‚æ•¸èªè­‰ï¼Œç´¯ç©ç¤¾æœƒæœå‹™ç¶“é©—ã€‚é€éŽå¯¦éš›åƒèˆ‡ï¼ŒåŸ¹é¤Šç¤¾æœƒè²¬ä»»æ„Ÿï¼Œç‚ºç¤¾å€å¸¶ä¾†æ­£é¢å½±éŸ¿ã€‚",
=======
                Title = "¬¡°ÊÅvÃÒ",
                Description = "°Ñ»PªÀ°ÏªA°È¬¡°Ê¡AÀò±oªA°È®É¼Æ»{ÃÒ¡A²Ö¿nªÀ·|ªA°È¸gÅç¡C³z¹L¹ê»Ú°Ñ»P¡A°ö¾iªÀ·|³d¥ô·P¡A¬°ªÀ°Ï±a¨Ó¥¿­±¼vÅT¡C",
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
                StartDate = DateTime.Now.AddDays(7),
                ImageUrl = "https://images.unsplash.com/photo-1544027993-37dbfe43562a?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=800&q=80"
            };
        }

    }
}
