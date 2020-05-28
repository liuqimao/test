using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public class MockFeedbackRepository : IFeedbackRepository
    {
        private List<Feedback> _feedbacks;//私有Feedback列表

        public MockFeedbackRepository()
        {
            if (_feedbacks == null)
            {
                InitializeFeedback();
            }
        }

        private void InitializeFeedback()
        {
            _feedbacks = new List<Feedback>
            {
                new Feedback { Id = 1, Name = "阿莱克斯", Email = "noname@hotmail.com", Message = "真的好细好细好细啊", CreateDateUTC = DateTime.UtcNow},
                new Feedback { Id = 2, Name = "莱克斯", Email = "noname@hotmail.com", Message = "还是挺细的", CreateDateUTC = DateTime.UtcNow},
                new Feedback { Id = 3, Name = "克斯", Email = "noname@hotmail.com", Message = "比细的粗点，比二细细点", CreateDateUTC = DateTime.UtcNow},
                new Feedback { Id = 4, Name = "克斯", Email = "noname@hotmail.com", Message = "粗的才有嚼劲", CreateDateUTC = DateTime.UtcNow},
            };
        }        

        //创建Feedback控制器
        public void AddFeedback(Feedback feedback)//实现AddFeedback函数
        {
            _feedbacks.Add(feedback);
        }

        public IEnumerable<Feedback> GetAllFeedbacks()
        {
            return _feedbacks;
        }
    }
}
