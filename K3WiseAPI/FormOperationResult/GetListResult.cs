using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.FormOperationResult
{
    public class GetListResult : FormResult
    {
        public ListResult Data { get; set; }
    }

    public class ListResult
    {
        public int ROWCOUNT { get; set; }
        public int PAGESIZE { get; set; }
        public int PAGEINDEX { get; set; }
        public object DATA { get; set; }
    }

    public class AccountListModel
    {
        public string FItemDetailName { get; set; }
        public Faccountitem[] FAccountItem { get; set; }
        public bool FDetail { get; set; }
        public string FFullName { get; set; }
        public string FName { get; set; }
        public string FNumber { get; set; }
    }
}
