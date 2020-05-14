using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.DynamicFormOperation
{
    /// <summary>
    ///执行 审核-获取详情-删除等操作
    /// </summary>
    public abstract class AuditAndDetailAndDelete : FormOperation
    {
        #region 公共覆盖操作参数
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
                var parmeters = new
                {
                    Data = new
                    {
                        FNumber = this.FNumber,
                        FCheckDirection = this.CheckDirection,
                        FChecker = this.Checker,
                        FDealComment = this.DealComment,
                    }
                };
                return JsonConvert.SerializeObject(parmeters, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            }
        }
        #endregion

        #region 公共覆盖操作属性
        /// <summary>
        /// 审核人
        /// </summary>
        public string Checker { get; set; }
        /// <summary>
        /// 审核动作(1:启动审核，2：审核，4：驳回)
        /// </summary>
        public string CheckDirection { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        public String FNumber { get; set; }
        /// <summary>
        /// 审核意见
        /// </summary>
        public string DealComment { get; set; }

        #endregion

        #region 公共方法

        /// <summary>
        /// 获取表单详情时设置单据编号
        /// </summary>
        /// <param name="orderNo"></param>
        /// <returns></returns>
        public virtual AuditAndDetailAndDelete SetBillNo(string orderNo)
        {
            this.FNumber = orderNo;
            return this;
        }
        /// <summary>
        /// 审核时 设置审核人
        /// </summary>
        /// <param name="checker"></param>
        /// <returns></returns>
        public virtual AuditAndDetailAndDelete SetChecker(string checker)
        {
            this.Checker = checker;
            return this;
        }
        /// <summary>
        /// 审核时 设置审核动作
        /// </summary>
        /// <param name="checkDirection"></param>
        /// <returns></returns>
        public virtual AuditAndDetailAndDelete SetCheckDirection(string checkDirection)
        {
            this.CheckDirection = checkDirection;
            return this;
        }
        /// <summary>
        /// 审核时 设置审核意见
        /// </summary>
        /// <param name="dealComment"></param>
        /// <returns></returns>
        public virtual AuditAndDetailAndDelete SetDealComment(string dealComment)
        {
            this.DealComment = dealComment;
            return this;
        }
        /// <summary>
        /// 设置读写动态表单类型标识
        /// </summary>
        /// <param name="objectId">表单标识ID</param>
        /// <returns></returns>
        public virtual AuditAndDetailAndDelete SetObjectTypeId(string objectId)
        {
            return SetObjectTypeId<AuditAndDetailAndDelete>(objectId);
        }
        /// <summary>
        /// 设置访问接口的token标识
        /// </summary>
        /// <param name="token">动态表单类型标识。</param>
        /// <returns>返回类本身实例对象。</returns>
        public virtual AuditAndDetailAndDelete SetToken(string token)
        {
            return SetToken<AuditAndDetailAndDelete>(token);
        }//end method

        #endregion
    }
}
