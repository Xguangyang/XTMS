using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS_Smart_logistics.Model;
using TMS_Smart_logistics.IRepository;

namespace TMS_Smart_logistics.Api.Controllers
{
    /// <summary>
    /// 部门
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class DepartmentController : Controller
    {
        public IDepartmentModel department;
        public IRoleModel roleModel;
        public DepartmentController(IDepartmentModel _department, IRoleModel _roleModel)
        {
            department = _department;
            roleModel = _roleModel;
        }
        //显示部门
        [HttpGet]
        public IActionResult Show(string DeparName="")
        {
            return Ok(department.GetDepartment(DeparName));
        }
        [HttpPost]
        //添加部门
        public IActionResult AddDepar(Model.DepartmentModel obj)
        {
            return Ok(department.AddDeparMent(obj));
        }
        [HttpPost]
        //删除部门
        public IActionResult DelDepar(int DeparMentID)
        {
            return Ok(department.DelDeparMent(DeparMentID));
        }
        
        
        //反填
        [HttpGet]
        public IActionResult FanDeparMent(int DeparMentID)
        {
            return Ok(department.FunDEparment(DeparMentID));
        }


    }
}
