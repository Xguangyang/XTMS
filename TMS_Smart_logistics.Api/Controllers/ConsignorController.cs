using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS_Smart_logistics.IRepository;
using TMS_Smart_logistics.Model;


namespace TMS_Smart_logistics.Api.Controllers
{
    /// <summary>
    /// 货主管理
    /// </summary>
    [Route("api/[controller]/[action]")]

    public class ConsignorController : Controller
    {
        public ILogger Logger;
        public IConsignor consignor;
        /// <summary>
        /// 依赖注入
        /// </summary>
        /// <param name="_consignor"></param>
        public ConsignorController(IConsignor _consignor, ILogger _Logger)
        {
            consignor = _consignor;
            Logger = _Logger;
        }
        /// <summary>
        /// 货主管理
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetConsignor(string EmployeeName="", string EmployeePhone="", string DrivingLicenceTime="")
        {
            try
            {
                List<ViewConsignor> lis = consignor.GetViewConsignors(EmployeeName, EmployeePhone, DrivingLicenceTime);
                if (lis != null)
                {
                    return Ok(new { Code = 1, Data = lis });
                }
                else
                {
                    return Ok(new { Code = 0, Data = "" });
                }
            }
            catch (Exception)
            {
                Logger.LogInformation("货主异常");
                return Ok("货主管理异常");
            }
          
        }
        /// <summary>
        /// 货主管理添加0
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddConsignor(ViewConsignor obj)
        {
            return Ok(consignor.AddConsignor(obj));
        }
        /// <summary>
        /// 货主管理删除0
        /// </summary>
        /// <param name="ConsignorID"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DelConsignor(string ConsignorID)
        {
            return Ok(consignor.DelConsignor(ConsignorID));
        }
        /// <summary>
        /// 货主管理修改0
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult UpdConsignor()
        {
            return Ok();
        }

    }
}
