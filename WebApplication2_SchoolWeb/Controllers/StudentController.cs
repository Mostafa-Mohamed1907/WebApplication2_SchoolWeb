using Microsoft.AspNetCore.Mvc;
using WebApplication2_SchoolWeb.Container;

namespace WebApplication2_SchoolWeb.Controllers
{
    public class StudentController : Controller
    {
        SchoolDB2Context context = new SchoolDB2Context();
        //StudentController/Index/2
        public IActionResult Index(int id)
        {
            var student = context.students!.Where(x => x.Id == id).FirstOrDefault();
            return View(student);
        }
    }
}
