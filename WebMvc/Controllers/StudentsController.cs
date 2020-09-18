using Microsoft.AspNetCore.Mvc;

namespace WebMvc.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}