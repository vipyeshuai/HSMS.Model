using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HSMS.Model
{
  public  class SalarySheetItem
    {
      public Guid Id { set; get; }
      public Guid SheetId { set; get; }
      public Guid EmployeeId { set; get; }
      public decimal BaseSalary { set; get; }
      public decimal Bonus { set; get; }
      public decimal Fine { set; get; }
      public decimal Other { set; get; }
    }
}
