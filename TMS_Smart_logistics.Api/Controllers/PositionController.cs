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
    /// 车辆管理
    /// </summary>
    [Route("api/[controller]/[action]")]
    
    public class PositionController : Controller
    {
        
        public IPositionModel position;
        public PositionController(IPositionModel _position)
        {
            position = _position;
        }
        [HttpGet]
        public IActionResult GetPosition(string PositionName="")
        {
            return Ok(position.GetPosition(PositionName));
        }
    }
}
