using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.DynamicFormOperation
{
    /// <summary>
    /// 执行修改操作
    /// </summary>
    public class Update_Wise : SaveAndUpdate
    {
        #region 公共覆盖操作参数

        public override string OperationName
        {
            get
            {
                return Path.Combine(this.ObjectTypeId, "Update").Replace(@"\", @"/");
            }
        }

        #endregion
    }
}
