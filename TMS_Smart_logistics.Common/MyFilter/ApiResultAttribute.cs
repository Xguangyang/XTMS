﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMS_Smart_logistics.Common.MyFilter
{
    /*
     * 对WebApi结果返回值进行统一格式包装过滤
     * 
     * **/

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method)]
    public class ApiWrapResultAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //模型验证
            if (!context.ModelState.IsValid)
            {
                throw new ApplicationException(context.ModelState.Values.First(p => p.Errors.Count > 0).Errors[0].ErrorMessage);
            }
            base.OnActionExecuting(context);
        }

        /// <summary>
        /// 处理正常返回的结果对象，进行统一json格式包装
        /// 异常只能交由ExceptionFilterAttribute 去处理 
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Result != null)
            {
                var result = context.Result as ObjectResult;
                JsonResult newresult;
                if (context.Result is ObjectResult)
                {
                    newresult = new JsonResult(new { code = 200, body = result.Value });
                }
                else if (context.Result is EmptyResult)
                {
                    newresult = new JsonResult(new { code = 200, body = new { } });
                }
                else
                {
                    throw new Exception($"未经处理的Result类型：{ context.Result.GetType().Name}");
                }
                context.Result = newresult;
            }
            base.OnActionExecuted(context);
        }
    }

    /*
     * 不需要包装的WebApi结果返回值处理
     * 
     * **/
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method)]
    public class NotApiWrapResultAttribute : ApiWrapResultAttribute
    {

    }
}
