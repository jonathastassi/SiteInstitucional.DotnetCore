using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SiteInstitucional.Application;

namespace SiteInstitucional.Mvc.Controllers
{
    public class ContatoController : Controller
    {
        public ContatoController(
        )
        {
        }

        public IActionResult Index([FromForm] ContatoViewModel model = null)
        {
            return View(model);
        }

        public IActionResult SendEmail([FromForm] ContatoViewModel model)
        {
            model.Status = "Mensagem  enviada com sucesso!";

            //TODO enviar e-mail

            return RedirectToAction("Index", model);
        }
    }
}