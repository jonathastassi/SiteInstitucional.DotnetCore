using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SiteInstitucional.Application;

namespace SiteInstitucional.Mvc.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioAppService portfolioAppService;

        public PortfolioController(
            IPortfolioAppService portfolioAppService
        )
        {
            this.portfolioAppService = portfolioAppService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await this.portfolioAppService.GetLatests();
            return View(items);
        }
    }
}