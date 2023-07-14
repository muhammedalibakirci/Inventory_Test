using Microsoft.AspNetCore.Mvc;
using proje1.Models;

namespace proje1.Controllers
{
    public class staffController : Controller
    {
        public IActionResult staff()
        {
            var staffList = new List<productModel>(){
                new productModel(){serialNum="145", itemName="asdn",barcode="ljn",brandID=123}

            };
            return View(staffList);
        }
    }
}
