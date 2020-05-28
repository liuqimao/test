using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Controllers
{
    //1.public class TestController
    //2.添加[Controller]
    //3.继承Controller类

    [Controller]
    public class Test :Controller
    {
        public ActionResult Index()
        {
            
            return Content("Hello From test index");//自动返回
        }

        public String About()
        {
            return "Hello from test About";
        }

        public ActionResult Contact()
        {
            return View();
        }

    }
}
