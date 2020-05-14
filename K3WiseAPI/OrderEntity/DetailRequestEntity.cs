using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.OrderEntity
{
    #region 请求操作参数

    /// <summary>
    /// 请求参数
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DetailRequestEntity
    {
        /// <summary>
        /// 审核实体
        /// </summary>
        public AuditRequestEntity Data { get; set; }
    }
    public class AuditRequestEntity
    {

        public string FBillNo { get; set; }
        public string FChecker { get; set; }
        public string FCheckDirection { get; set; }
        public string FDealComment { get; set; }

    }

    #endregion
}
