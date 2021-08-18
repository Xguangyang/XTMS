using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS_Smart_logistics.Model;
using TMS_Smart_logistics.IRepository;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Authorization;

namespace TMS_Smart_logistics.Api.Controllers
{

    /// <summary>
    /// 部门
    /// </summary>
    [Authorize]
    [Route("api/[controller]/[action]")]

    public class DepartmentController : Controller
    {
        /// <summary>
        /// 
        /// </summary>

        public IDepartmentModel department;
        /// <summary>
        /// 依赖注入
        /// </summary>
        /// <param name="_department"></param>
        public DepartmentController(IDepartmentModel _department)
        {
            department = _department;
          
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
        /// 添加部门0
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        
        public IActionResult AddDepar(Model.DepartmentModel obj)
        {
            return Ok(department.AddDeparMent(obj));
        }
        /// <summary>
        /// 删除部门1
        /// </summary>
        /// <param name="DeparMentID"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DelDepar(int DeparMentID)
        {
            return Ok(department.DelDeparMent(DeparMentID));
        }


        /// <summary>
        /// 反填0
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
