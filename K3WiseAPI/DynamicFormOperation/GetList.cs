using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.DynamicFormOperation
{
    /// <summary>
    /// 执行获取表单列表的操作
    /// </summary>
    public class GetList : FormOperation
    {
        #region  公共覆盖请求参数

        /// <summary>
        /// 操作名称
        /// </summary>
        public override string OperationName
        {
            get
            {
                return Path.Combine(this.ObjectTypeId, "GetList").Replace(@"\", @"/");
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
                var parametersArray = new
                {
                    Data = new
                    {

                        Top = this.TopCount,
                        PageSize = this.PageSize == default(int) ? 2000 : this.PageSize,
                        PageIndex = this.PageIndex,
                        Filter = string.IsNullOrEmpty(this.Filter) ? "" : this.Filter,
                        OrderBy = string.IsNullOrEmpty(this.OrderBy) ? "" : this.OrderBy,
                        Fields = this.Fields == null ? "" : string.Join(",", this.Fields),
                        SelectPage = string.IsNullOrEmpty(this.SelectPage) ? "2" : this.SelectPage,
                    }
                };

                return JsonConvert.SerializeObject(parametersArray);
            }

        }
        #endregion

        #region  公共属性

        /// <summary>
        /// 读写最多允许查询的数量属性值。
        /// </summary>
        /// <remarks>
        /// 0或者不要此属性表示不限制。
        /// </remarks>
        public virtual int TopCount { get; set; }
        /// <summary>
        /// 读写分页取数每页允许获取的数据属性值。
        /// </summary>
        /// <remarks>
        /// 最大不能超过2000。
        /// </remarks>
        public virtual int PageSize { get; set; }
        /// <summary>
        /// 读写分页取数开始行索引属性值。
        /// </summary>
        /// <remarks>
        /// 从0开始，例如每页10行数据，第2页开始是10，第3页开始是20，以此类推，当不提供此属性，表示仅查询Limit中填写的数据量。
        public virtual int PageIndex { get; set; }
        /// <summary>
        /// 读写过滤条件属性值。
        /// </summary>
        public virtual string Filter { get; set; }//end property

        /// <summary>
        /// 读写排序条件属性值。
        /// </summary>
        public virtual string OrderBy { get; set; }//end property

        /// <summary>
        /// 读写表单返回数据字段的索引键属性值。
        /// </summary>
        public virtual List<string> Fields { get; set; }//end property
        public virtual string SelectPage { get; set; }

        #endregion

        #region  公共方法

        /// <summary>
        /// 设置读写的动态表单标识ID 
        /// </summary>
        /// <param name="objectTypeId"></param>
        /// <returns></returns>
        public virtual GetList SetObjectTypeId(string objectTypeId)
        {
            return this.SetObjectTypeId<GetList>(objectTypeId);
        }//end method

        /// <summary>
        /// 设置最多允许查询的单据数量。
        /// </summary>
        /// <param name="topRowCount">单据数量值。</param>
        /// <returns>返回类本身实例对象。</returns>
        public virtual GetList SetTopRowCount(int topCount)
        {
            this.TopCount = topCount;
            return this;
        }
        /// <summary>
        /// 设置分页取数每页允许获取的单据数量。
        /// </summary>
        /// <param name="pageRowCount">分页数量值。</param>
        /// <returns>返回类本身实例对象。</returns>
        public virtual GetList SetPageSize(int pagesize)
        {
            this.PageSize = pagesize;
            return this;
        }
        /// <summary>
        /// 设置分页取数开始行索引。
        /// </summary>
        /// <param name="pageIndex">索引值。</param>
        /// <returns>返回类本身实例对象。</returns>
        public virtual GetList SetPageIndex(int pageIndex)
        {
            this.PageIndex = pageIndex;
            return this;
        }
        /// <summary>
        /// 设置过滤条件。
        /// </summary>
        /// <param name="filter">过滤条件。</param>
        /// <returns>返回类本身实例对象。</returns>
        public virtual GetList SetFilter(string filter)
        {
            this.Filter = filter;
            return this;
        }//end method

        /// <summary>
        /// 设置排序条件。
        /// </summary>
        /// <param name="orderBy">排序条件。</param>
        /// <returns>返回类本身实例对象。</returns>
        public virtual GetList SetOrderBy(string orderBy)
        {
            this.OrderBy = orderBy;
            return this;
        }//end method

        /// <summary>
        /// 表单返回数据字段。
        /// </summary>
        /// <param name="fieldKey">字段索引键。</param>
        /// <returns>返回类本身实例对象。</returns>
        public virtual GetList AddFieldKey(string fieldKey)
        {
            if (this.Fields == null)
            {
                this.Fields = new List<string>();
            }//end if

            this.Fields.Add(fieldKey);
            return this;
        }//end method

        /// <summary>
        /// 设置表体索引
        /// </summary>
        /// <param name="selectPage"></param>
        public virtual GetList SetSelectPage(string selectPage)
        {
            this.SelectPage = selectPage;
            return this;
        }

        /// <summary>
        /// 设置token标识
        /// </summary>
        /// <param name="token">动态表单类型标识。</param>
        /// <returns>返回类本身实例对象。</returns>
        public virtual GetList SetToken(string token)
        {
            return SetToken<GetList>(token);
        }//end method
        #endregion
    }

}
