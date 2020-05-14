using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.DynamicFormOperation
{
    /// <summary>
    ///执行新增操作
    /// </summary>
    public class Save_Wise : SaveAndUpdate
    {
        #region  公共覆盖请求参数

        public override string OperationName
        {
            get
            {
                return Path.Combine(this.ObjectTypeId, "Save").Replace(@"\", @"/");
            }
        }
        #endregion
    }
}
