using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.DynamicFormOperation
{
    /// <summary>
    /// 执行删除操作
    /// </summary>
    public class Delete_Wise : AuditAndDetailAndDelete
    {
        #region 公共覆盖操作参数
        /// <summary>
        /// 操作名称
        /// </summary>
        public override string OperationName
        {
            get
            {
                return Path.Combine(this.ObjectTypeId, "Delete").Replace(@"\", @"/");
            }
        }
        #endregion
    }
}
