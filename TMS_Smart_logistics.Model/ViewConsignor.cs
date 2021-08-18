using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Smart_logistics.Model
{
    /// <summary>
    /// 货主管理
    /// </summary>
   public class ViewConsignor
    {
        public string EmployeeName { get; set; }
        public string EmployeePhone { get; set; }
        public string OutsourcingUnitName { get; set; }
        public string OutsourcingUnitPlace { get; set; }
        public DateTime DrivingLicenceTime { get; set; }
        public string DrivingLicenceImg { get; set; }
        public string Remark { get; set; }
        public DateTime OutsourcingUnitCreateTime { get; set; }

    }
}
