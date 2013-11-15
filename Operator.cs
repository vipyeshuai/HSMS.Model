using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HSMS.Model
{
   public class Operator
    {
       public Guid Id { set; get; }
       public string UserName { set; get; }
       public string Password { set; get; }
       public bool IsDelete { set; get; }
       public string RealName { set; get; }
       public bool IsNocked { set; get; }
    }
}
