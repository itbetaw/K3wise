using Middleware.Target.Core.Models.K3Wise.K3WiseAPI.OrderEntity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.DynamicFormOperation
{
    /// <summary>
    /// 执行新增-修改操作
    /// </summary>
    public abstract class SaveAndUpdate : FormOperation
    {
        #region 公共覆盖操作参数

        /// <summary>
        /// 请求参数
        /// </summary>
        public override string RequestParameters
        {
            get
            {
                var parameters = new
                {
                    FBillNo = BillNo,
                    Data = new
                    {
                        page1 = new Page1[] { },
                        page2 = new Page2[] { },
                        page3 = new Page3[] { },
                    }
                };
                return JsonConvert.SerializeObject(parameters, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            }
        }

        #endregion

        #region 公共操作参数属性

        public virtual object Model { get; set; }

        public virtual string BillNo { get; set; }

        #endregion

        #region 公共方法

        /// <summary>
        /// 设置读写动态表单类型标识
        /// </summary>
        /// <param name="objectTypeId"></param>
        /// <returns></returns>
        public virtual SaveAndUpdate SetToken(string token)
        {
            return SetToken<SaveAndUpdate>(token);
        }
        /// <summary>
        /// 设置读写动态表单类型标识
        /// </summary>
        /// <param name="objectTypeId"></param>
        /// <returns></returns>
        public virtual SaveAndUpdate SetObjectTypeId(string objectTypeId)
        {
            return SetObjectTypeId<SaveAndUpdate>(objectTypeId);
        }
        /// <summary>
        /// 设置更新时单据的编号
        /// </summary>
        /// <param name="billNo"></param>
        /// <returns></returns>
        public virtual T SetBillNo<T>(string billNo) where T : APIOperation
        {
            this.BillNo = billNo;
            return this as T;
        }
        /// <summary>
        /// 设置更新时单据的编号
        /// </summary>
        /// <param name="billNo"></param>
        /// <returns></returns>
        public virtual SaveAndUpdate SetBillNo(string billNo)
        {
            return SetBillNo<SaveAndUpdate>(billNo);
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
        public virtual SaveAndUpdate SetModel(object model)
        {
            return SetModel<SaveAndUpdate>(model);
        }

        #endregion
    }
}
