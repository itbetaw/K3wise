using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.DynamicFormOperation
{
    /// <summary>
    /// 执行获取Token操作
    /// </summary>
    public class GetToken : FormOperation
    {
        #region 公共覆盖操作参数

        /// <summary>
        /// 操作名称
        /// </summary>
        public override string OperationName
        {
            get
            {
                return Path.Combine("Token", "Create").Replace(@"\", @"/");
            }
        }
        /// <summary>
        /// 请求参数 空-代表无
        /// </summary>
        public override string RequestParameters
        {
            get
            {
                return null;
            }

        }
        /// <summary>
        /// 请求类型
        /// </summary>
        public override string RequestType { get { return "Get"; } }

        #endregion

        #region 公共方法

        /// <summary>
        /// 设置访问授权码
        /// </summary>
        /// <param name="authCode"></param>
        /// <returns></returns>
        public virtual GetToken SetAuthorityCode(string authCode)
        {
            return SetAuthorityCode<GetToken>(authCode);
        }

        #endregion
    }
}
