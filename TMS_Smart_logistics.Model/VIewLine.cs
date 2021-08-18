using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Smart_logistics.Model
{
   public class VIewLine
    {
        public int CircuitAdministrationID { get; set; } //线路ID
        public string CircuitName { get; set; }        // 线路名称
        public string CircuitStartPlace { get; set; }  // 起点
        public string CircuitEndPlace { get; set; }    // 终点
        public string IsOutsource { get; set; }        // 是否外协
        public string EmployeeName { get; set; }
        public string EmployeePhone { get; set; }
        public string OutsourcingUnitName { get; set; }
        public string Remark { get; set; }        //备注
        public DateTime CreateTime { get; set; }  //创建时间
        public int CircuitStatus { get; set; }    //状态（1：开启2：禁用）

    }
}
