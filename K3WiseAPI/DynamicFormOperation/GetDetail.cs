using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.DynamicFormOperation
{
    /// <summary>
    /// 执行获取表单详情操作
    /// </summary>
    public class GetDetail : FormOperation
    {
        #region 公共覆盖操作参数
        /// <summary>
        /// 操作名称
        /// </summary>
        public override string OperationName
        {
            get
            {
                return Path.Combine(this.ObjectTypeId, "GetDetail").Replace(@"\", @"/");
            }
        }
        /// <summary>
        /// 请求类型
        /// </summary>
        public override string RequestType { get { return "Post"; } }
        public override string RequestParameters
        {
            get
            {
                var parametersArray = new
                {
                    Data = new
                    {

                        FNumber = this.FNumber
                    }
                };

                return JsonConvert.SerializeObject(parametersArray);
            }
        }

        #endregion
        public virtual string FNumber { get; set; }


        /// <summary>
        /// 设置最多允许查询的单据数量。
        /// </summary>
        /// <param name="topRowCount">单据数量值。</param>
        /// <returns>返回类本身实例对象。</returns>
        public virtual GetDetail SetFnumber(string Fnumber)
        {
            this.FNumber = Fnumber;
            return this;
        }
        /// <summary>
        /// 设置读写的动态表单标识ID 
        /// </summary>
        /// <param name="objectTypeId"></param>
        /// <returns></returns>
        public virtual GetDetail SetObjectTypeId(string objectTypeId)
        {
            return this.SetObjectTypeId<GetDetail>(objectTypeId);
        }//end method

        /// <summary>
        /// 设置token标识
        /// </summary>
        /// <param name="token">动态表单类型标识。</param>
        /// <returns>返回类本身实例对象。</returns>
        public virtual GetDetail SetToken(string token)
        {
            return SetToken<GetDetail>(token);
        }//end method
    }
}
