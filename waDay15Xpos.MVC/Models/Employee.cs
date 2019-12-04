using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace waDay15Xpos.MVC.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Lasttname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}