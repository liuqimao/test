using LanzhouBeefNoodles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.ViewModels
{
    public class HomeViewModels
    {
        public IList<Noodle> Noodles { get; set; }
        public IList<Feedback> Feedbacks { get; set; }
        

    }
}
