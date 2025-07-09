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
                // 輪播圖數據
                CarouselItems = GetCarouselItems(),

                // 功能卡片數據
                FeatureCards = GetFeatureCards(),

                // 新消息數據
                NewsItems = GetNewsItems(),

                // 活動權證數據
=======
                // �����ϼƾ�
                CarouselItems = GetCarouselItems(),

                // �\��d���ƾ�
                FeatureCards = GetFeatureCards(),

                // �s�����ƾ�
                NewsItems = GetNewsItems(),

                // �����v�Ҽƾ�
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
                ActivityInfo = GetActivityInfo()
            };

            return View(model);
        }

        public IActionResult Contact()
        {
<<<<<<< HEAD
            ViewData["Title"] = "這裡是聯絡我們";
            return View(); // 聯絡我們
=======
            ViewData["Title"] = "�o�̬O�p���ڭ�";
            return View(); // �p���ڭ�
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
        }

        public IActionResult Organization()
        {
<<<<<<< HEAD
            ViewData["Title"] = "這裡是組織介紹";
            return View(); // 組織介紹
        }
        // 模擬數據方法
=======
            ViewData["Title"] = "�o�̬O��´����";
            return View(); // ��´����
        }
        // �����ƾڤ�k
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
        private List<CarouselItem> GetCarouselItems()
        {
            return new List<CarouselItem>
    {
        new CarouselItem
        {
            ImageUrl = "https://images.unsplash.com/photo-1559027615-cd4628902d4a?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1000&q=80",
<<<<<<< HEAD
            Title = "歡迎來到NGO物資平台",
            Description = "連結NGO組織與資源，共創美好社會"
=======
            Title = "�w��Ө�NGO���ꥭ�x",
            Description = "�s��NGO��´�P�귽�A�@�Ь��n���|"
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
        },
        new CarouselItem
        {
            ImageUrl = "https://images.unsplash.com/photo-1582213782179-e0d53f98f2ca?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1000&q=80",
<<<<<<< HEAD
            Title = "專業社工培訓課程",
            Description = "提升專業技能，服務社會大眾"
=======
            Title = "�M�~���u���V�ҵ{",
            Description = "���ɱM�~�ޯ�A�A�Ȫ��|�j��"
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
        },
        new CarouselItem
        {
            ImageUrl = "https://images.unsplash.com/photo-1469571486292-0ba58a3f068b?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1000&q=80",
<<<<<<< HEAD
            Title = "志工招募中",
            Description = "加入我們，一起為社會貢獻力量"
=======
            Title = "�Ӥu�۶Ҥ�",
            Description = "�[�J�ڭ̡A�@�_�����|�^�m�O�q"
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
            Title = "報名證照",
            Description = "專業證照課程報名與管理",
=======
            Title = "���W�ҷ�",
            Description = "�M�~�ҷӽҵ{���W�P�޲z",
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
            IconUrl = "/images/icon1.png"
        },
        new FeatureCard
        {
<<<<<<< HEAD
            Title = "活動管理",
            Description = "志工活動與社區服務",
=======
            Title = "���ʺ޲z",
            Description = "�Ӥu���ʻP���ϪA��",
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
            IconUrl = "/images/icon2.png"
        },
        new FeatureCard
        {
<<<<<<< HEAD
            Title = "組織介紹",
            Description = "了解各NGO組織資訊",
=======
            Title = "��´����",
            Description = "�F�ѦUNGO��´��T",
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
            IconUrl = "/images/icon3.png"
        },
        new FeatureCard
        {
<<<<<<< HEAD
            Title = "智庫資料",
            Description = "專業知識與資源分享",
=======
            Title = "���w���",
            Description = "�M�~���ѻP�귽����",
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
            Title = "2024年社工專業認證開始報名",
            Date = DateTime.Now.AddDays(-1),
            Content = "即日起開放報名，名額有限請把握機會"
        },
        new NewsItem
        {
            Title = "新增線上課程功能",
            Date = DateTime.Now.AddDays(-2),
            Content = "現在可以透過線上方式參與課程學習"
=======
            Title = "2024�~���u�M�~�{�Ҷ}�l���W",
            Date = DateTime.Now.AddDays(-1),
            Content = "�Y��_�}����W�A�W�B�����Чⴤ���|"
        },
        new NewsItem
        {
            Title = "�s�W�u�W�ҵ{�\��",
            Date = DateTime.Now.AddDays(-2),
            Content = "�{�b�i�H�z�L�u�W�覡�ѻP�ҵ{�ǲ�"
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
        }
    };
        }

        private ActivityInfo GetActivityInfo()
        {
            return new ActivityInfo
            {
<<<<<<< HEAD
                Title = "活動權證",
                Description = "參與社區服務活動，獲得服務時數認證，累積社會服務經驗。透過實際參與，培養社會責任感，為社區帶來正面影響。",
=======
                Title = "�����v��",
                Description = "�ѻP���ϪA�Ȭ��ʡA��o�A�Ȯɼƻ{�ҡA�ֿn���|�A�ȸg��C�z�L��ڰѻP�A���i���|�d���P�A�����ϱa�ӥ����v�T�C",
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
                StartDate = DateTime.Now.AddDays(7),
                ImageUrl = "https://images.unsplash.com/photo-1544027993-37dbfe43562a?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=800&q=80"
            };
        }

    }
}
