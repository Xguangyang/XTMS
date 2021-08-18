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
    /// 进项发票
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class ReceiptsController : Controller
    {

        public IReceiptsNvoice receipts;
        public ReceiptsController(IReceiptsNvoice _receipts)
        {
            receipts = _receipts;
        }
        /// <summary>
        /// 进项发票 显示
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetPay()
        {
            return Ok(receipts.GetDepartment());
        }
        /// <summary>
        /// 进项发票
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddPay(ReceiptsNvoice obj)
        {
            return Ok(receipts.AddReceiptsNvoice(obj));
        }
        /// <summary>
        /// 进项发票 删除
        /// </summary>
        /// <param name="PayAdministrationID"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DelPays(int ReceiptsNvoiceID)
        {
            return Ok(receipts.DelReceiptsNvoice(ReceiptsNvoiceID));
        }
        /// <summary>
        /// 进项发票 修改
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult UpdPays(ReceiptsNvoice obj)
        {
            return Ok(receipts.UpdReceiptsNvoice(obj));
        }
    }
}
