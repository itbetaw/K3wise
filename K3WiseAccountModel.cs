using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise
{
    public class K3WiseAccountDetail
    {
        public int FAccountID { get; set; }
        public Faccountitem[] FAccountItem { get; set; }
        public bool FDetail { get; set; }
        public string FFullName { get; set; }
        public object FHelperCode { get; set; }
        public string FName { get; set; }
        public string FNumber { get; set; }
    }

    public class Faccountitem
    {
        public string FItemClassName { get; set; }
        public string FItemClassNumber { get; set; }
    }

    public class K3WiseBasicInfo
    {
        public string FName { get; set; }
        public string FNumber { get; set; }
    }
}
