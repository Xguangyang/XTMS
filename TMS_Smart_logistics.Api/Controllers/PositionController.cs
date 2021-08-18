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
    /// 职位管理
    /// </summary>
    [Route("api/[controller]/[action]")]

    public class PositionController : Controller
    {

        /// <summary>
        /// 依赖注入
        /// </summary>
        public IPositionModel position;
        /// <summary>
        /// 依赖注入
        /// </summary>
        /// <param name="_position"></param>
        /// <param name="_logger"></param>
        public PositionController(IPositionModel _position)
        {
            position = _position;
        }
        /// <summary>
        /// 显示职位
        /// </summary>
        /// <param name="PositionName"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetPosition(string PositionName="")
        {

            return Ok(position.GetPosition(PositionName));
        }
    }
}
