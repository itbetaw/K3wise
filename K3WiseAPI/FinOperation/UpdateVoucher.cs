using Middleware.Target.Core.Models.K3Wise.K3WiseAPI.DynamicFormOperation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.FinOperation
{
    /// <summary>
    /// 执行凭证引入操作
    /// </summary>
    public class UpdateVoucher : FormOperation
    {
        #region  公共覆盖请求参数

        /// <summary>
        /// 操作名称
        /// </summary>
        public override string OperationName
        {
            get
            {
                return Path.Combine(this.ObjectTypeId, "UpdateVoucher").Replace(@"\", @"/");
            }
        }

        /// <summary>
        /// 请求类型
        /// </summary>
        public override string RequestType { get { return "Post"; } }
        /// <summary>
        /// 请求参数
        /// </summary>
        public override string RequestParameters
        {
            get
            {
                var parameters = new
                {
                    Replace = this.Replace,
                    VoucherData = this.Model,
                };
                return JsonConvert.SerializeObject(parameters);
            }
        }

        #endregion

        #region  公共属性

        /// <summary>
        /// 设置请求参数实体
        /// </summary>
        public virtual object Model { get; set; }
        public string Replace { get; set; }

        #endregion

        #region  公共方法

        /// <summary>
        /// 设置访问的token参数
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public virtual UpdateVoucher SetToken(string token)
        {
            return SetToken<UpdateVoucher>(token);
        }
        /// <summary>
        /// 设置读写动态表单类型标识
        /// </summary>
        /// <param name="objectId"></param>
        /// <returns></returns>
        public virtual UpdateVoucher SetObjectId(string objectId)
        {
            return SetObjectTypeId<UpdateVoucher>(objectId);
        }
        /// <summary>
        /// 设置待保存的数据对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual T SetModel<T>(object model) where T : APIOperation
        {
            this.Model = model;
            return this as T;
        }

        /// <summary>
        /// 设置待保存的数据对象
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual UpdateVoucher SetModel(object model)
        {
            return SetModel<UpdateVoucher>(model);
        }

        /// <summary>
        /// 设置凭证引出的替换
        /// </summary>
        /// <param name="replace"></param>
        /// <returns></returns>
        public virtual UpdateVoucher SetReplace(string replace)
        {
            this.Replace = replace;
            return this;
        }

        #endregion
    }
}
