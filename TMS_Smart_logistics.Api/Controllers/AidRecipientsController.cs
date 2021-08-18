using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS_Smart_logistics.Model;
using TMS_Smart_logistics.IRepository;
using Microsoft.Extensions.Logging;

namespace TMS_Smart_logistics.Api.Controllers
{
    /// <summary>
    /// 物资领用管理
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class AidRecipientsController : Controller
    {
        public ILogger<AidRecipientsController> logger;

        public IViewAidRecipients viewAid;
        public AidRecipientsController (IViewAidRecipients _viewAid, ILogger<AidRecipientsController> _logger)
        {
            viewAid = _viewAid;
            logger = _logger;
        }
        /// <summary>
        /// 显示物资领用1
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAidRecipients()
        {
            try
            {
                List<ViewAidRecipients> Lis1 = viewAid.GetAidRecipients();
                if (Lis1 != null)
                {

                    return Ok(new { Code = 1, data = Lis1, Mess = "请求成功" });
                }
                else
                {
                    logger.LogInformation("显示物资 返回结果为空");
                    return Ok(new { Code = 0, data = "", Mess = "失败请求" });
                }
            }
            catch (Exception)
            {

                return Ok("物资显示 请求失败");
            }
        }
        /// <summary>
        /// 添加物资领用0
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AddAidRecipients(ViewAidRecipients obj)
        {
            return View();
        }
        /// <summary>
        /// 删除物资领用0
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult DelAidRecipients(ViewAidRecipients obj)
        {
            return View();
        }
        /// <summary>
        /// 修改物资领用0
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult UpdAidRecipients(ViewAidRecipients obj)
        {
            return View();
        }
    }
}
