using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;
using Microsoft.AspNetCore.Mvc;
using LanzhouBeefNoodles.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LanzhouBeefNoodles.Controllers
{
    //[Route("Home")]
    //[Route("[controller]/[action]")]

    public class HomeController : Controller
    {
        private INoodleRepository _noodleRepository;    //
        private IFeedbackRepository _feedbackRepository;//添加数据的仓库

        public HomeController(INoodleRepository noodleRepository,IFeedbackRepository feedbackRepository)//通过参数
        {
            _noodleRepository = noodleRepository;
            _feedbackRepository = feedbackRepository;//
        }

        //[Route("[action]")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            //var noodles = _noodleRepository.GetAllNoodles();//
            var viewModle = new HomeViewModels()              //创建新的视图模型
            {
                Feedbacks = _feedbackRepository.GetAllFeedbacks().ToList(),//强制转换为列表
                Noodles = _noodleRepository.GetAllNoodles().ToList()
            };                
            return View(viewModle);                          //视图模型与主页面绑定
        }         

        //[Route("[action]")]
        public String About()
        {
            return "Hello From About";
        }

        public IActionResult Detail(int id)
        {
            
            return View(_noodleRepository.GetNoodleById(id));
        }
    }
}
