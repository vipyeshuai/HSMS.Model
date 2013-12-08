using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HSMS.Model
{
   public class Department
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public bool IsStopped { set; get; }
    }
}
