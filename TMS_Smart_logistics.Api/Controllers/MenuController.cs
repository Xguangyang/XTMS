using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS_Smart_logistics.Model;
using TMS_Smart_logistics.IRepository;

namespace TMS_Smart_logistics.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public class MenuController : Controller
    {
        public IMenuModel menu;
        public MenuController(IMenuModel _menu)
        {
            menu = _menu;
        }
        [HttpGet]
        public IActionResult GetMenu()
        {
            return Ok(menu.GetMenu());
        }
    }
}
