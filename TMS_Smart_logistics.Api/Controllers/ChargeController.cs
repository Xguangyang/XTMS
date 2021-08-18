using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS_Smart_logistics.IRepository;
using TMS_Smart_logistics.Model;
namespace TMS_Smart_logistics.Api.Controllers
{
    /// <summary>
    /// 应收显示
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class ChargeController : Controller
    {
        public ICharge charge;
        public ChargeController(ICharge _charge)
        {
            charge = _charge;
        }
        /// <summary>
        /// 显示 应收
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCharge()
        {
            try
            {
                return Ok(charge.GetCharges());
            }
            catch (Exception)
            {

                return Ok("显示异常");
            }
        }
        /// <summary>
        /// 应收 删除
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DelCharge(string ChargeId)
        {
            try
            {
                return Ok(charge.DelCharge(ChargeId));
            }
            catch (Exception)
            {

                return Ok("删除异常");
            }
        }
        /// <summary>
        /// 应收添加
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddCharge(Charge obj)
        {
            try
            {
                return Ok(charge.AddCharge(obj));
            }
            catch (Exception)
            {

                return Ok("显示异常");
            }
        }
        /// <summary>
        /// 应收修改
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult UpdCharge(Charge obj)
        {
            try
            {
                return Ok(charge.UpdCharge(obj));
            }
            catch (Exception)
            {

                return Ok("显示异常");
            }
        }

    }
}
