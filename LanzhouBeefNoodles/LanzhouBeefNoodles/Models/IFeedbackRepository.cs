using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public interface IFeedbackRepository
    {
        IEnumerable<Feedback> GetAllFeedbacks();//返回一个类型为Feedback的列表        
        void AddFeedback(Feedback feedback);    //定义
    }
}
