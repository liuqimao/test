using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanzhouBeefNoodles.Controllers
{
    public class FeedbackController : Controller
    {
        private IFeedbackRepository _feedbackpository;


        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackpository = feedbackRepository;
        }

        public IActionResult Index()//创建评价页面
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            //Tag Helper
            if (ModelState.IsValid)
            {
                _feedbackpository.AddFeedback(feedback);
                return RedirectToAction("FeedbackComplete");
            }
            return View();

        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}