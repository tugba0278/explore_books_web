using Microsoft.AspNetCore.Mvc;

namespace explore_books.Pages.PROJECT.controller
{
    public class HomeController : Controller

        
    {
        private db context;

        public HomeController(db _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddRequest()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddRequest(Request model)
        {
            context.Add(model);
            context.SaveChanges();
            return View();
        }
    }
}
