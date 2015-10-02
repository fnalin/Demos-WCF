using DemoWCFSingleton.WebUI.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DemoWCFSingleton.WebUI.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {

            IList<AlunoVM> alunos;

            using (var _ctx = new AlunoRepositorio())
            {
                alunos = _ctx.GetAlunos();
            }


            return View(alunos);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}