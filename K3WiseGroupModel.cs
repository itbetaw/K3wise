using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise
{
    public class K3WiseGroupModel
    {
        public GroupModel Data { get; set; }
    }

    public class GroupModel
    {
        public GroupEntities[] Data { get; set; }
        public int RowCount { get; set; }
    }

    public class GroupEntities
    {
        public int FGroupID { get; set; }
        public string FName { get; set; }
    }
}
