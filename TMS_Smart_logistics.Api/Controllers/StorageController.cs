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
    /// 入库管理
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class StorageController : Controller
    {
        public IStorageAdministration storage;
        public StorageController(IStorageAdministration _storage)
        {
            storage = _storage;
        }
        /// <summary>
        /// 入库管理显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetStorage()
        {
            List<StorageAdministration> Lis1 = storage.GetStorages();
            return Ok(Lis1);
        }
    }
}
