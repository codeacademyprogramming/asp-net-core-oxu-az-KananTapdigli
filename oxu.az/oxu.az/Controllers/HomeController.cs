using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using oxu.az.Abstractions;
using oxu.az.Contexts;
using oxu.az.Models;

namespace oxu.az.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsRepository _newsRepository;
        private readonly ICategoryRepository _categoryRepository;

        public HomeController(ILogger<HomeController> logger, INewsRepository newsRepository, ICategoryRepository categoryRepository)
        {
            _logger = logger;
            _newsRepository = newsRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var featuredNews = _newsRepository.GetFeaturedNews();
            var generalNews = _newsRepository.GetAllNews();

            HomeIndexViewModel model = new HomeIndexViewModel()
            {
                FeaturedNews = featuredNews,
                GeneralNews = generalNews
            };

            return View(model);
        }

        public IActionResult News(int Id)
        {
            var chosenNews = _newsRepository.GetNews(Id);

            return View(chosenNews);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
