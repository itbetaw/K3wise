using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.FormOperationResult
{
    public class GetTokenResult : FormResult
    {
        public TokenResult Data { get; set; }
    }
    public class TokenResult
    {
        public string Token { get; set; }
        public string Code { get; set; }
        public float Validity { get; set; }
        public string IPAddress { get; set; }
        public string Language { get; set; }
        public string Create { get; set; }
    }

}
