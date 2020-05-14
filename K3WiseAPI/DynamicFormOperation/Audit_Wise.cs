using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.DynamicFormOperation
{
    /// <summary>
    /// 执行审核操作
    /// </summary>
    public class Audit_Wise : AuditAndDetailAndDelete
    {
        #region 公共覆盖操作参数
        public override string OperationName
        {
            get
            {
                return Path.Combine(this.ObjectTypeId, "CheckBill").Replace(@"\", @"/");
            }
        }
        #endregion
    }
}
