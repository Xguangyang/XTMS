using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Smart_logistics.IRepository
{
   public interface IPayAdministration:IBase<Model.PayAdministration>
    {
        List<Model.PayAdministration> GetPays();
        /// <summary>
        /// 应付 批删
        /// </summary>
        /// <param name="StorageID"></param>
        /// <returns></returns>
        int DelPays(string PayAdministrationID);
        /// <summary>
        /// 应付 添加
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        int AddPays(Model.PayAdministration obj);
        /// <summary>
        /// 应付 修改
        /// </summary>
        /// <param name="onj"></param>
        /// <returns></returns>

        int UpdPays(Model.PayAdministration onj);
    }
}
