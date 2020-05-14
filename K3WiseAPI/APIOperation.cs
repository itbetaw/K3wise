using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI
{
    public abstract class APIOperation
    {
        /// <summary>
        /// k3Wise URL
        /// 例如：http://127.0.0.1/K3API
        /// </summary>
        public virtual string RootUrl { get; set; }
        public abstract string OperationName { get; }
        public virtual string RequestUrl
        {
            get
            {
                return Path.Combine(RootUrl, OperationName).Replace(@"\", @"/");
            }
        }
        public virtual string AuthorityCode { get; set; }
        public abstract string RequestParameters { get; }//end property
        public virtual string RequestType { get; set; }
        /// <summary>
        /// 默认构造方法，什么都不做。
        /// </summary>
        public APIOperation()
        {
            //DO NOTHING
        }//end constructor

        /// <summary>
        /// 构造方法，将K/3 Cloud系统的根级URL在实例化时传入。
        /// </summary>
        /// <param name="rootUrl">K/3 Cloud系统的根级URL。</param>
        public APIOperation(string rootUrl)
        {
            this.RootUrl = rootUrl;
        }//end constructor

        /// <summary>
        /// 设置K/3 Wise系统的根级URL。
        /// </summary>
        /// <typeparam name="T">继承APIOperation的类。</typeparam>
        /// <param name="rootUrl">K/3Wise系统的根级URL，例如：http://127.0.0.1/K3API </param>
        /// <returns>返回T定义类型的实例对象。</returns>
        public virtual T SetRootUrl<T>(string rootUrl) where T : APIOperation
        {
            this.RootUrl = rootUrl;
            return this as T;
        }//end method
        public virtual string Token { get; set; }
        public T SetToken<T>(string token) where T : APIOperation
        {
            this.Token = token;
            return this as T;
        }
        public T SetAuthorityCode<T>(string authorityCode) where T : APIOperation
        {
            this.AuthorityCode = authorityCode;
            return this as T;
        }

        /// <summary>
        /// 转向API请求。
        /// </summary>
        /// <returns>返回API请求实例对象。</returns>
        public virtual T ToAPIRequest<T>() where T : APIRequest, new()
        {
            return new T().SetOperation<T>(this);
        }//end method

        /// <summary>
        /// 转向API请求。
        /// </summary>
        /// <returns>返回API请求实例对象。</returns>
        public virtual APIRequest ToAPIRequest()
        {
            return this.ToAPIRequest<APIRequest>();
        }//end method
    }
}
