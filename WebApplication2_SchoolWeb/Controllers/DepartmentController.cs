using Microsoft.AspNetCore.Mvc;
using WebApplication2_SchoolWeb.Container;

namespace WebApplication2_SchoolWeb.Controllers
{
    public class DepartmentController : Controller
    {
        SchoolDB2Context context = new SchoolDB2Context();
        //DepartmentController/Details
        public IActionResult Detils()
        {
            var dept = context.departments!.ToList();
            return View(dept);
        }
    }
}
