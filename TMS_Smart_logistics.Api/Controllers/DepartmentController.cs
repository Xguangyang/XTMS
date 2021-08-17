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
        /// <summary>
        /// 
        /// </summary>
        public IDepartmentModel department;
        /// <summary>
        /// 
        /// </summary>
        public IRoleModel roleModel;
        /// <summary>
        /// 依赖注入
        /// </summary>
        /// <param name="_department"></param>
        /// <param name="_roleModel"></param>
        public DepartmentController(IDepartmentModel _department, IRoleModel _roleModel)
        {
            department = _department;
            roleModel = _roleModel;
        }

        /// <summary>
        /// 显示部门
        /// </summary>
        /// <param name="DeparName"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Show(string DeparName="")
        {
            return Ok(department.GetDepartment(DeparName));
        }
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        
        public IActionResult AddDepar(Model.DepartmentModel obj)
        {
            return Ok(department.AddDeparMent(obj));
        }
        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="DeparMentID"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DelDepar(int DeparMentID)
        {
            return Ok(department.DelDeparMent(DeparMentID));
        }


        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="DeparMentID"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult FanDeparMent(int DeparMentID)
        {
            return Ok(department.FunDEparment(DeparMentID));
        }


    }
}
