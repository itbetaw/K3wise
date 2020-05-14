using CloudField.Framework.HttpHelper;
using CloudField.Framework.HttpHelper.Enum;
using CloudField.Framework.UI;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI
{
    public class APIRequest
    {
        public HttpHelper HttpHelper;

        private string _parameters;

        #region 公共属性

        /// <summary>
        /// 请求参数，针对操作需要传入的参数，由调用者提供
        /// </summary>
        [JsonProperty("parameters")]
        public string Parameters
        {
            get
            {
                return _parameters;
            }//end get
            set
            {
                _parameters = value;
            }
        }//end property

        #region Json不序列化属性

        /// <summary>
        /// 通过构造方法接收到的API操作对象。
        /// </summary>
        [JsonIgnore]
        public APIOperation Operation { get; private set; }//end property

        /// <summary>
        /// HTTP发起请求完整的URL
        /// </summary>
        [JsonIgnore]
        public string URL { get; set; }//end property
        public string Token { get; set; }
        public string AuthorityCode { get; set; }
        /// <summary>
        /// HTTP请求的编码格式，默认为UTF8。
        /// </summary>
        [JsonIgnore]
        public Encoding Encoder { get; set; }//end property

        public string RequestType { get; set; }

        /// <summary>
        /// HTTP请求的Header部分
        /// </summary>
        [JsonIgnore]
        public Dictionary<string, object> Headers { get; protected set; }//end property

        /// <summary>
        /// HTTP请求的Body部分字符串
        /// </summary>
        [JsonIgnore]
        public string Body
        {
            get
            {
                return JsonConvert.SerializeObject(this);
            }
        }//end property

        /// <summary>
        /// HTTP请求的Body部分二进制
        /// </summary>
        [JsonIgnore]
        public byte[] Buffer
        {
            get
            {
                return this.Encoder.GetBytes(this.Body);
            }
        }//end property

        #endregion

        #endregion

        #region 构造方法

        /// <summary>
        /// 默认构造方法，给部分属性设置默认值，除了URL和Parameters。
        /// </summary>
        public APIRequest()
        {
            this.SetDefaultValue();
        }//end constructor

        /// <summary>
        /// 构造方法，只需要传入URL和文本参数即可，其它参数一般无需理会。
        /// </summary>
        /// <param name="url">URL。</param>
        /// <param name="parameters">文本字符串，一般是Json序列化后的字符串。</param>
        public APIRequest(string url, string parameters)
        {
            this.URL = url;
            this.Parameters = parameters;

            this.SetDefaultValue();
        }//end constructor

        /// <summary>
        /// 构造方法，将APIOperation实例对象传入生成一个APIRequest对象。
        /// </summary>
        /// <param name="operation">APIOperation实例对象。</param>
        public APIRequest(APIOperation operation)
        {
            HttpHelper = new HttpHelper();
            this.Operation = operation;
            this.Token = operation.Token;
            this.URL = operation.RequestUrl;
            this.AuthorityCode = operation.AuthorityCode;
            this.Parameters = operation.RequestParameters;
            this.RequestType = operation.RequestType;

            this.SetDefaultValue();
        }//end constructor

        #endregion

        #region 公共方法

        /// <summary>
        /// 将APIOperation实例对象传入生成一个APIRequest对象。
        /// </summary>
        /// <typeparam name="T">指定的类型，该类型继承APIRequest。</typeparam>
        /// <param name="operation">APIOperation实例对象。</param>
        /// <returns>返回指定的类型实例对象，该类型继承APIRequest。</returns>
        public T SetOperation<T>(APIOperation operation) where T : APIRequest
        {
            HttpHelper = new HttpHelper();
            this.Operation = operation;
            this.Token = operation.Token;
            this.AuthorityCode = operation.AuthorityCode;
            this.URL = operation.RequestUrl;
            this.Parameters = operation.RequestParameters;
            this.RequestType = operation.RequestType;
            return this as T;
        }//end method

        #endregion

        #region 私有方法

        /// <summary>
        /// 设置部分属性的默认值。
        /// </summary>
        private void SetDefaultValue()
        {
            this.Headers = new Dictionary<string, object>();
            this.Headers.Add("Content-Type", "application/json");
            this.Headers.Add("charset", "UTF-8");
        }//end method

        /// <summary>
        /// 以同步的形式发起HTTP表单动作请求并返回执行结果，
        /// 结果以泛型反序列化获得。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Excute<T>() where T : class
        {
            HttpItem item = new HttpItem();
            StringBuilder sb = new StringBuilder();
            sb.Append("token");
            sb.Append("=");
            sb.Append(this.Token);
            sb.Insert(0, "?");
            URL += sb.ToString();
            if (string.IsNullOrEmpty(this.Token))
            {
                throw new UserFriendlyException("token参数是必需的");
            }
            item.URL = this.URL;
            if (this.RequestType.ToLower() == HttpMethod.Post.Method.ToLower())
            {
                item.PostDataType = PostDataType.String;
                item.PostEncoding = Encoding.UTF8;
                item.Postdata = this.Parameters;
                item.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
            }
            item.Method = this.RequestType;
            var html = this.HttpHelper.GetHtml(item);
            var result = JsonConvert.DeserializeObject<T>(html.Html);
            return result;
        }

        /// <summary>
        /// <summary>
        /// 以同步的形式发起HTTP获取Token请求并返回执行结果，
        /// 结果以泛型反序列化获得。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetToken<T>() where T : class
        {
            HttpItem item = new HttpItem();
            StringBuilder sb = new StringBuilder();
            sb.Append("authorityCode");
            sb.Append("=");
            sb.Append(this.AuthorityCode);
            sb.Insert(0, "?");
            URL += sb.ToString();
            item.URL = this.URL;
            if (string.IsNullOrEmpty(this.AuthorityCode))
            {
                throw new UserFriendlyException("授权码不能为空");
            }
            item.Method = this.RequestType;
            var html = this.HttpHelper.GetHtml(item);
            var result = JsonConvert.DeserializeObject<T>(html.Html);
            return result;
        }

        #endregion

    }
}