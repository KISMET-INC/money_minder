using Microsoft.AspNetCore.Mvc;
using money_minder.Models;
namespace money_minder.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }




        [HttpGet("")]     
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("bill")]     
        public IActionResult ShowBill()
        {
            return View();
        }
    }
}