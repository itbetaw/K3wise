using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.OrderEntity
{
    public class ListRequestEntity
    {
        public ListRequestParamemter Data { get; set; }
    }
    public class ListRequestParamemter
    {
        public int Top { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public string Filter { get; set; }
        public string OrderBy { get; set; }
        public string SelectPage { get; set; }
        public string Fields { get; set; }
    }
}
