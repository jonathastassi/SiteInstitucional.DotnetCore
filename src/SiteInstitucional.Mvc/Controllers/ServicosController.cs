using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SiteInstitucional.Mvc.Controllers
{
    public class ServicosController : Controller
    {
        public ServicosController(
        )
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}