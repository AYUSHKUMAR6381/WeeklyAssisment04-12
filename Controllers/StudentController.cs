using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeeklyAssisment_04_12.Models;

namespace WeeklyAssisment_04_12.Controllers
{
    public class StudentController : Controller
    {
        List<Student> sList = new List<Student>()
        {
            new Student{SId=1,SName="Ayush",SDob="24/04/1999",SContect="1236547890"},
            new Student{SId=2,SName="Rahul",SDob="25/04/2020",SContect="7896541230"},
            new Student{SId=3,SName="Rajiv",SDob="26/04/1999",SContect="1236542590"},
            new Student{SId=4,SName="Sam",SDob="27/04/1999",SContect="1236548890"},
            new Student{SId=5,SName="Jayyant",SDob="28/04/1999",SContect="1986547890"},

        };
        public IActionResult Display()
        {
            ViewBag.NOS = sList.Count;
            return View(sList);
        }
    }
}
