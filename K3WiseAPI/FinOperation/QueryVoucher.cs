using Middleware.Target.Core.Models.K3Wise.K3WiseAPI.DynamicFormOperation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.FinOperation
{
    /// <summary>
    ///执行 凭证引出操作
    /// </summary>
    public class QueryVoucher : FormOperation
    {

        #region  公共覆盖请求参数

        public override string OperationName
        {
            get
            {
                return Path.Combine(this.ObjectTypeId, "QueryVoucher").Replace(@"\", @"/");
            }
        }

        public override string RequestParameters
        {
            get
            {
                var parameters = new
                {
                    Filter = Filter,
                };
                return JsonConvert.SerializeObject(parameters);
            }

        }

        /// <summary>
        /// 请求类型
        /// </summary>
        public override string RequestType { get { return "Post"; } }

        #endregion

        #region  公共属性

        /// <summary>
        /// 过滤条件Filter : 过滤条件，比如 FVoucherID=185
        /// </summary>
        public virtual string Filter { get; set; }

        #endregion

        #region  公共方法

        /// <summary>
        /// 设置查询条件
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public virtual QueryVoucher SetFilter(string filter)
        {
            this.Filter = filter;
            return this;
        }
        /// <summary>
        /// 设置读写动态表单类型标识
        /// </summary>
        /// <param name="objectId"></param>
        /// <returns></returns>
        public virtual UpdateVoucher SetObjectId(string objectId)
        {
            return SetObjectTypeId<UpdateVoucher>(ObjectTypeId);
        }
        /// <summary>
        /// 设置访问的token参数
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public virtual QueryVoucher SetToken(string token)
        {
            return SetToken<QueryVoucher>(token);
        }
        #endregion
    }
}
