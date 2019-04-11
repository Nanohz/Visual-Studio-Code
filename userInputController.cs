using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projectGetUser.Models;

namespace projectGetUser.Controllers
{
    public class userInputController : Controller
    {
        public IActionResult getUserFactObj()
        {
            GetInfo obj = new GetInfo();
            obj.firstName = " ";
            obj.lastName = "";
            obj.age = Convert.ToInt16("") ;
            return View(obj);

        }





        public IActionResult getUserFact(string firstName, string lastName, int age)
        {
            GetInfo iobj = new GetInfo();
            iobj.firstName = "firstName ";
            iobj.lastName = "lastName";
            iobj.age = age;

            return View(iobj);
        }
    }
}