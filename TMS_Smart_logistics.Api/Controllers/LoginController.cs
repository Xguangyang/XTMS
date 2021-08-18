using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS_Smart_logistics.Model;
using TMS_Smart_logistics.IRepository;
using TMS_Smart_logistics.Repository;
using Microsoft.Extensions.Logging;
using TMS_Smart_logistics.Common;
using Microsoft.AspNetCore.Authorization;

namespace TMS_Smart_logistics.Api.Controllers
{
    /// <summary>
    /// 登录
    /// </summary>
    [Route("api/[controller]/[action]")]
    
    public class LoginController : Controller
    {
       /// <summary>
       /// 登录I
       /// </summary>
        public ILogin login;
        /// <summary>
        /// 日志
        /// </summary>
        public ILogger<LoginController> logger;

        public JWTService jwt; 
        /// <summary>
        /// 依赖注入
        /// </summary>
        /// <param name="_login"></param>
        /// <param name="_logger"></param>
        public LoginController(ILogin _login,ILogger<LoginController> _logger, JWTService _jwt)
        {
            login = _login;
            logger = _logger;
            jwt = _jwt;
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPasd"></param>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]//不用jwt验证
        public IActionResult Login(string UserName,string UserPasd)
        {
            try
            {
                List<UserModel> a = login.Logins(UserName, UserPasd);

                if (a.Count > 0)
                {
                    logger.LogInformation("登陆成功");
                    var _jwt = jwt.GetToken(UserPasd);
                    return Ok(new { Code=1,Data=_jwt,Message="成功登陆"});

                }
                return Ok(new { code = 0, megss = "账号或密码错误" });
            }
            catch (Exception)
            {

                return Ok("登录异常");
            }
        
           
           
        }

    }
}
