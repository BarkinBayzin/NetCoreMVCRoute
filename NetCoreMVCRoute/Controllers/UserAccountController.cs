using Microsoft.AspNetCore.Mvc;
using NetCoreMVCRoute.Models.InputModels;
using NetCoreMVCRoute.Models.ViewModels;
using System.Collections.Generic;

namespace NetCoreMVCRoute.Controllers
{
    //localhost4550/UserAccount/Index => Defaultta UserAccount/Index Url
    //Account/User => Route Attribute kullandığımızda Startup.cs classında tanımlandığı kural tabanlı yönlendirmelerden farklı olarak controller veya actionlara özel tanımlamalar ile kullanabiliriz.
    //Route Attribte ile yönlendirme işlemleri
    [Route("Account")]
    public class UserAccountController : Controller
    {
        [Route("User")]
        public IActionResult Index()
        {
            var userInfo = new UserInfoVM
            {
                EMail = "georgeorwell@outlook.com",
                UserName = "George Orwell",
                InformationText = "Edebiyat",
                Roles = new List<string> { "Yazar", "Gazeteci", "Eleştirmen" }
            };

            return View(userInfo);
        }

        //Parametreli Routing Kullanımı
        [Route("Parameters/{email}/{userName}/{informationText}")]
        public IActionResult Parameters(string email, string userName, string informationText)
        {
            UserInfoVM model = new UserInfoVM()
            {
                EMail = email,
                UserName = userName,
                InformationText = informationText
            };

            return View(model);
        }

        //HttpGet, HttpPost attributeları ile yönlendirme
        [HttpGet("UserCreate")]
        public IActionResult UserCreate()
        {
            return View();
        }

        [HttpPost("UserCreate")]
        public IActionResult UserCreate(UserFormIM userModel)
        {
            return View();
        }
    }
}
