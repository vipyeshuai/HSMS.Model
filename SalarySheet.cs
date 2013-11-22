using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HSMS.Model
{
  public  class SalarySheet
    {
      public Guid Id { set; get; }
      public int Year { set; get; }
      public int Month { set; get; }
      public Guid DeptId { set; get; }
    }
}
