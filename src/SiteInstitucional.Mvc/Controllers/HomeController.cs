using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SiteInstitucional.Application;
using SiteInstitucional.Mvc.Models;

namespace SiteInstitucional.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPortfolioAppService portfolioAppService;

        public HomeController(
            ILogger<HomeController> logger,
            IPortfolioAppService portfolioAppService)
        {
            _logger = logger;
            this.portfolioAppService = portfolioAppService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await this.portfolioAppService.GetLatests(8);
            return View(items);
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
}
