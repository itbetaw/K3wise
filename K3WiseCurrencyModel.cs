using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise
{
    public class K3WiseCurrencyModel
    {
        public CurrencyModel Data { get; set; }
    }

    public class CurrencyModel
    {
        public CurrencyEntities[] Data { get; set; }
        public int RowCount { get; set; }
    }

    public class CurrencyEntities
    {
        public string FCurrencyNumber { get; set; }
        public string FCurrencyName { get; set; }
        public int FCurrencyID { get; set; }

    }
}
