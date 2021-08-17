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
    /// 角色
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class RoleController : Controller
    {
        public IRoleModel role;
        public RoleController(IRoleModel _role)
        {
            role = _role;
        }

        [HttpGet]
        public IActionResult RoleShow(string RoleName)
        {
            return Ok(role.GetRole(RoleName));
        }
    }
}
