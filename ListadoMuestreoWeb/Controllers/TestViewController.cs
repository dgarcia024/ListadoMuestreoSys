using ListadoMuestreoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListadoMuestreoWeb.Controllers
{
    public class TestViewController : Controller
    {
        // GET: TestViewController
        public ActionResult Index()
        {
            var data = new TestViewModel {
                Name = "Daniel Garcia",
                BirthDate = new DateOnly(1993,04,24)
            };
            return View(data);
        }

    }
}
