using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Smart_logistics.Model
{
    /// <summary>
    /// 员工表
    /// </summary>
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }                                //员工主键自增不为空
        public string EmployeeName { get; set; }                           //员工姓名
        public string EmployeeSex { get; set; }                            //员工性别
        public string EmployeePhone { get; set; }                          //员工手机
        public Nullable<int> EmployeeType { get; set; }                    //员工类别（1：正式员工2：实习生3：试用工）
        public Nullable<System.DateTime> EmployeeEntryTime { get; set; }   //员工入职申请
        public Nullable<System.DateTime> EmployeeEndWorkTime { get; set; } //员工最后工作日
        public string EmployeeLeaveSession { get; set; }                   //员工离职时间
        public Nullable<System.DateTime> EmployeeProposerTime { get; set; }//员工申请时间
        public string EmployeeParentName { get; set; }                     //上级负责人
        public Nullable<System.DateTime> CreateTime { get; set; }          //创建时间
        public Nullable<int> EmployeeStatus { get; set; }                  //状态
    }
}


