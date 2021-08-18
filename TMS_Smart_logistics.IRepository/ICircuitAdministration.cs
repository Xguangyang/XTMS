using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.Model;

namespace TMS_Smart_logistics.IRepository
{
    /// <summary>
    /// 线路管理
    /// </summary>
   public interface ICircuitAdministration:IBase<Model.VIewLine>
    {
        List<Model.VIewLine> GetVIewLines(string CircuitName, string CircuitStartPlace, string CircuitEndPlace, string IsOutsource, string EmployeeName, string OutsourcingUnitName);

        /// <summary>
        /// 线路删除  批删
        /// </summary>
        /// <param name="StorageID"></param>
        /// <returns></returns>
        int DelLines(string CircuitAdministrationID);
        /// <summary>
        /// 线路删除
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        int AddLines(Model.VIewLine obj);
        /// <summary>
        /// 线路修改
        /// </summary>
        /// <param name="onj"></param>
        /// <returns></returns>

        int UpdLines(Model.VIewLine onj);
    }
}
