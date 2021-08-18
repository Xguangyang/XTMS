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
    /// 应付
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class PayAController : Controller
    {

        public IPayAdministration pay;
        public PayAController (IPayAdministration _pay)
        {
            pay = _pay;
        }
        /// <summary>
        /// 应付显示
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetPay()
        {
            return Ok(pay.GetPays());
        }
        /// <summary>
        /// 添加应付
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddPay(PayAdministration obj)
        {
            return Ok(pay.AddPays(obj));
        }
        /// <summary>
        /// 应付 删除
        /// </summary>
        /// <param name="PayAdministrationID"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DelPays(string PayAdministrationID)
        {
            return Ok(pay.DelPays(PayAdministrationID));
        }
        /// <summary>
        /// 修改 应付
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult UpdPays(PayAdministration obj)
        {
            return Ok(pay.UpdPays(obj));
        }
    }
}
