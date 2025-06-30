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
                // �����ϼƾ�
                CarouselItems = GetCarouselItems(),

                // �\��d���ƾ�
                FeatureCards = GetFeatureCards(),

                // �s�����ƾ�
                NewsItems = GetNewsItems(),

                // �����v�Ҽƾ�
                ActivityInfo = GetActivityInfo()
            };

            return View(model);
        }

        public IActionResult Contact()
        {
            ViewData["Title"] = "�o�̬O�p���ڭ�";
            return View(); // �p���ڭ�
        }

        public IActionResult Organization()
        {
            ViewData["Title"] = "�o�̬O��´����";
            return View(); // ��´����
        }
        // �����ƾڤ�k
        private List<CarouselItem> GetCarouselItems()
        {
            return new List<CarouselItem>
    {
        new CarouselItem
        {
            ImageUrl = "https://images.unsplash.com/photo-1559027615-cd4628902d4a?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1000&q=80",
            Title = "�w��Ө�NGO���ꥭ�x",
            Description = "�s��NGO��´�P�귽�A�@�Ь��n���|"
        },
        new CarouselItem
        {
            ImageUrl = "https://images.unsplash.com/photo-1582213782179-e0d53f98f2ca?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1000&q=80",
            Title = "�M�~���u���V�ҵ{",
            Description = "���ɱM�~�ޯ�A�A�Ȫ��|�j��"
        },
        new CarouselItem
        {
            ImageUrl = "https://images.unsplash.com/photo-1469571486292-0ba58a3f068b?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1000&q=80",
            Title = "�Ӥu�۶Ҥ�",
            Description = "�[�J�ڭ̡A�@�_�����|�^�m�O�q"
        }
    };
        }

        private List<FeatureCard> GetFeatureCards()
        {
            return new List<FeatureCard>
    {
        new FeatureCard
        {
            Title = "���W�ҷ�",
            Description = "�M�~�ҷӽҵ{���W�P�޲z",
            IconUrl = "/images/icon1.png"
        },
        new FeatureCard
        {
            Title = "���ʺ޲z",
            Description = "�Ӥu���ʻP���ϪA��",
            IconUrl = "/images/icon2.png"
        },
        new FeatureCard
        {
            Title = "��´����",
            Description = "�F�ѦUNGO��´��T",
            IconUrl = "/images/icon3.png"
        },
        new FeatureCard
        {
            Title = "���w���",
            Description = "�M�~���ѻP�귽����",
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
            Title = "2024�~���u�M�~�{�Ҷ}�l���W",
            Date = DateTime.Now.AddDays(-1),
            Content = "�Y��_�}����W�A�W�B�����Чⴤ���|"
        },
        new NewsItem
        {
            Title = "�s�W�u�W�ҵ{�\��",
            Date = DateTime.Now.AddDays(-2),
            Content = "�{�b�i�H�z�L�u�W�覡�ѻP�ҵ{�ǲ�"
        }
    };
        }

        private ActivityInfo GetActivityInfo()
        {
            return new ActivityInfo
            {
                Title = "�����v��",
                Description = "�ѻP���ϪA�Ȭ��ʡA��o�A�Ȯɼƻ{�ҡA�ֿn���|�A�ȸg��C�z�L��ڰѻP�A���i���|�d���P�A�����ϱa�ӥ����v�T�C",
                StartDate = DateTime.Now.AddDays(7),
                ImageUrl = "https://images.unsplash.com/photo-1544027993-37dbfe43562a?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=800&q=80"
            };
        }

    }
}
