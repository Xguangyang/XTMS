using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.IRepository;
using TMS_Smart_logistics.Model;

namespace TMS_Smart_logistics.IRepository
{
   public interface IStorageAdministration:IBase<Model.StorageAdministration>
    {
        /// <summary>
        /// 入库显示
        /// </summary>
        /// <returns></returns>
        List<Model.StorageAdministration> GetStorages();
        /// <summary>
        /// 入库删除  批删
        /// </summary>
        /// <param name="StorageID"></param>
        /// <returns></returns>
        int DelStorages(string StorageID);
        /// <summary>
        /// 入库添加
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        int AddStorageID(Model.StorageAdministration obj);
        /// <summary>
        /// 入库修改
        /// </summary>
        /// <param name="onj"></param>
        /// <returns></returns>

        int UpdStorages(Model.StorageAdministration onj);


    }
}
