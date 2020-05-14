using Middleware.Target.Core.Models.K3Wise.K3WiseAPI.DynamicFormOperation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.FinOperation
{
    /// <summary>
    /// 执行删除凭证
    /// </summary>
    public class DeleteVoucher : FormOperation
    {
        #region 公共覆盖属性参数

        public override string OperationName
        {
            get
            {
                return Path.Combine(this.ObjectTypeId, "DeleteVoucher").Replace(@"\", @"/");
            }
        }

        public override string RequestParameters
        {
            get
            {
                var paramemter = new
                {
                    FVoucherID = this.VoucherID,
                };
                return JsonConvert.SerializeObject(paramemter);
            }
        }
        /// <summary>
        /// 请求类型
        /// </summary>
        public override string RequestType { get { return "Post"; } }

        #endregion

        #region 公共属性

        /// <summary>
        /// 凭证ID
        /// </summary>
        public virtual string VoucherID { get; set; }

        #endregion

        #region 公共方法

        /// <summary>
        /// 设置访问的token参数
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public virtual DeleteVoucher SetToken(string token)
        {
            return SetToken<DeleteVoucher>(token);
        }
        /// <summary>
        /// 设置读写动态表单类型标识
        /// </summary>
        /// <param name="objectId"></param>
        /// <returns></returns>
        public virtual DeleteVoucher SetObjectId(string objectId)
        {
            return SetObjectTypeId<DeleteVoucher>(ObjectTypeId);
        }
        /// <summary>
        /// 设置要删除的凭证ID
        /// </summary>
        /// <param name="voucherId"></param>
        /// <returns></returns>
        public virtual DeleteVoucher SetVoucherID(string voucherId)
        {
            this.VoucherID = voucherId;
            return this;
        }

        #endregion

    }
}
