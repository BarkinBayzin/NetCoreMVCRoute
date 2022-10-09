using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVCRoute.Controllers
{
    public class DynamicController : Controller
    {
        //name ve id parametrelerine göre uygun data çekilip ekrana model gönderilir.
        public IActionResult Detail(string name, string id)
        {
            return View();
        }
    }
}
