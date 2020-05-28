using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

namespace WcfService4
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "你好 世界";
        }

        [WebMethod(Description ="求和的方法")]
       public int jiafa(int x,int y)
        {
            return x + y;
        }
    }
}
