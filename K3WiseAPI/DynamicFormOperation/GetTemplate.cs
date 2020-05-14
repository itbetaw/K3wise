using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.DynamicFormOperation
{
    /// <summary>
    /// 执行获取模板的操作
    /// </summary>
    public class GetTemplate : FormOperation
    {
        #region 公共覆盖操作参数

        /// <summary>
        /// 操作名称
        /// </summary>
        public override string OperationName
        {
            get
            {
                return Path.Combine(this.ObjectTypeId, "GetTemplate").Replace(@"\", @"/");
            }
        }
        /// <summary>
        /// 请求参数
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
        /// 设置读写动态表单类型标识。
        /// </summary>
        /// <param name="objectTypeId">动态表单类型标识。</param>
        /// <returns>返回类本身实例对象。</returns>
        public virtual GetTemplate SetObjectTypeId(string objectTypeId)
        {
            return SetObjectTypeId<GetTemplate>(objectTypeId);
        }//end method

        /// <summary>
        /// 设置token标识
        /// </summary>
        /// <param name="token">动态表单类型标识。</param>
        /// <returns>返回类本身实例对象。</returns>
        public virtual GetTemplate SetToken(string token)
        {
            return SetToken<GetTemplate>(token);
        }//end method

        #endregion
    }
}
