using Microsoft.AspNetCore.Authorization;
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
    /// 物资采购管理
    /// </summary>
    [Route("api/[controller]/[action]")]
    //[Authorize]
    public class GoodsAndMaterialsController : Controller
    {
        /// <summary>
        /// 依赖注入
        /// </summary>
        public IGoodsAndMaterials goodsAndMaterials;
        /// <summary>
        /// 依赖注入
        /// </summary>
        /// <param name="_goodsAndMaterials"></param>
        public GoodsAndMaterialsController(IGoodsAndMaterials _goodsAndMaterials)
        {
            goodsAndMaterials = _goodsAndMaterials;
        }
        /// <summary>
        /// 物资采购显示 
        /// </summary>
        /// <param name="GoodsAndMaterialsName">货物名字</param>
        /// <param name="TextureName">输入材质</param>
        /// <param name="PlaceOfOrigin">产地</param>
        /// <param name="Proposer">申请人</param>
        /// <param name="ExamineName">审批状态</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetGoodAndMaterials(string GoodsAndMaterialsName="", string TextureName="", string PlaceOfOrigin="", string Proposer="", string ExamineName="")
        {
            List<Supplies> Lis1 = goodsAndMaterials.GetAndMaterials(GoodsAndMaterialsName, TextureName, PlaceOfOrigin, Proposer, ExamineName);
            if (Lis1!=null)
            {
                return Ok(new { Code = 1, data = Lis1, Mess = "请求成功" });
            }
            else
            {
                return Ok(new { Code = 0, data = "", Mess = "失败请求" });
            }

            
        }
        /// <summary>
        /// 物资采购添加 0
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddGoodsAndMaterials()
        {
            return View();
        }
        /// <summary>
        /// 物资采购删除0
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DelGoodsAndMaterials()
        {
            return View();
        }
        /// <summary>
        /// 物资采购 修改0
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult UpdGoodsAndMaterials()
        {
            return View();
        }
    }
}
