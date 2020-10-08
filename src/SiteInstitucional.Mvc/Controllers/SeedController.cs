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
    public class SeedController : Controller
    {
        private readonly IPortfolioAppService portfolioAppService;

        public SeedController(
            IPortfolioAppService portfolioAppService)
        {
            this.portfolioAppService = portfolioAppService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            for (int i = 0; i < 15; i++)
            {
                await this.portfolioAppService.Insert(new PortfolioViewModel("Portffolio " + i.ToString(), "https://source.unsplash.com/200x150/?house"));
            }

            return Ok();
        }
    }
}
