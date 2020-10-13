using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SiteInstitucional.Mvc.Controllers
{
    public class SobreController : Controller
    {
        public SobreController(
        )
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}