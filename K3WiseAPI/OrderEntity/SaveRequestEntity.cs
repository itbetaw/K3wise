using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.OrderEntity
{
    #region 请求参数操作类

    public class SaveRequestEntity
    {
        public string FBillNo { get; set; }
        public Entity Data { get; set; }
    }
    public class Entity
    {
        public Page1[] page1 { get; set; }
        public Page2[] page2 { get; set; }

        public Page3[] page3 { get; set; }
    }
    public class Page1 { }
    public class Page2 { }
    public class Page3 { }

    #endregion
}
