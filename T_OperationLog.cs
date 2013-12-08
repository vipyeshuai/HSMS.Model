using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HSMS.Model
{
    public class T_OperationLog
    {
        public System.Guid Id { set; get; }
        public System.Guid OperatorId { set; get; }
        public System.DateTime MakeDate { set; get; }
        public System.String ActionDesc { set; get; }
    }
}
