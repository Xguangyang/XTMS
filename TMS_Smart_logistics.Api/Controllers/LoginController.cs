using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS_Smart_logistics.Model;
using TMS_Smart_logistics.IRepository;
using TMS_Smart_logistics.Repository;
using Microsoft.Extensions.Logging;

namespace TMS_Smart_logistics.Api.Controllers
{
    /// <summary>
    /// 登录
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class LoginController : Controller
    {
        public ILogin login;
        public ILogger<LoginController> logger;
        public LoginController(ILogin _login,ILogger<LoginController> _logger)
        {
            login = _login;
            logger = _logger;
        }
        [HttpGet]
        public IActionResult Login(string UserName,string UserPasd)
        {
            logger.LogInformation("我是朱阳龙他爹");
            return Ok(login.Logins(UserName,UserPasd));
        }
    }
}
