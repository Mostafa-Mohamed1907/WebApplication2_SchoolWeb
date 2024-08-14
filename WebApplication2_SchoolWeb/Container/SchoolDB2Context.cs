using Microsoft.EntityFrameworkCore;
using WebApplication2_SchoolWeb.Models;

namespace WebApplication2_SchoolWeb.Container
{
    public class SchoolDB2Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-A1088VT\\ADMIN;Database=School2DB;User Id=sa;password=Admin123;Integrated security=True;Encrypt=False");

        }

        public virtual Student? students { get; set; }
        public virtual Department? departments { get; set; }
    }
}
