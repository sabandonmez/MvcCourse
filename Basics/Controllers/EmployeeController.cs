using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
     public class EmployeeController:Controller
     {
      public IActionResult Index1() 
      {
        var message = $"Hello World.{DateTime.Now.ToString()}";
        return View("Index1",message);
      }
      public ViewResult Index2()
      {
        var names=new String[]
        {
            "Ahmet",
            "Mehmet",
            "Hüseyin"
        };
        return View(names);
      }
      public IActionResult Index3()
      {
        var list=new List<Employee>()
        {
            new Employee(){Id=1,FirstName="Şaban",LastName="Dönmez",Age=22},
            new Employee(){Id=2,FirstName="Samet",LastName="Dönmez",Age=20},
            new Employee(){Id=3,FirstName="Şehrazat",LastName="Dönmez",Age=17}
        };
        return View(list);
      }
     }
}