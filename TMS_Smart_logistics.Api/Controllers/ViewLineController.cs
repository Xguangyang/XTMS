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
    /// 线路
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class ViewLineController : Controller
    {
        public ICircuitAdministration circuit;
        public ViewLineController (ICircuitAdministration _circuit)
        {
            circuit = _circuit;
        }
        /// <summary>
        /// 显示1
        /// </summary>
        /// <param name="CircuitName"></param>
        /// <param name="CircuitStartPlace"></param>
        /// <param name="CircuitEndPlace"></param>
        /// <param name="IsOutsource"></param>
        /// <param name="EmployeeName"></param>
        /// <param name="OutsourcingUnitName"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetLine(string CircuitName="", string CircuitStartPlace="", string CircuitEndPlace="", string IsOutsource="", string EmployeeName="", string OutsourcingUnitName="")
        {
            return Ok(circuit.GetVIewLines(CircuitName,CircuitStartPlace,CircuitEndPlace,IsOutsource,EmployeeName,OutsourcingUnitName));
        }
        /// <summary>
        /// 添加0
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddLine(VIewLine obj)
        {
            return Ok(circuit.AddLines(obj));
        }
        /// <summary>
        /// 删除0
        /// </summary>
        /// <param name="CircuitAdministrationID"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DelLine(string CircuitAdministrationID)
        {
            return Ok(circuit.DelLines(CircuitAdministrationID));
        }
        /// <summary>
        /// 修改0
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult UpdLine(VIewLine obj)
        {
            return Ok(circuit.UpdLines(obj));
        }
    }
}
