using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Smart_logistics.IRepository
{
   public interface ICharge:IBase<Model.Charge>
    {
        /// <summary>
        /// 应付
        /// </summary>
        /// <returns></returns>
        List<Model.Charge> GetCharges();
        /// <summary>
        /// 添加应付
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        int AddCharge(Model.Charge obj);
        /// <summary>
        /// 应付 删除
        /// </summary>
        /// <param name="ChargeId"></param>
        /// <returns></returns>
        int DelCharge(string ChargeId);
        /// <summary>
        /// 应付 修改
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        int UpdCharge(Model.Charge obj);
    }
}
