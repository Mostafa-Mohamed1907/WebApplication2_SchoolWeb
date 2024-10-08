﻿namespace WebApplication2_SchoolWeb.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;   
        public string Address { get; set; }=string.Empty;
        public string Image { get; set; } = string.Empty;

        public virtual Department? Department { get; set; }
    }
}
