using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.Model;

namespace TMS_Smart_logistics.IRepository
{
    /// <summary>
    /// 货主管理
    /// </summary>
   public interface IConsignor:IBase<ViewConsignor>
    {
        List<ViewConsignor> GetViewConsignors(string EmployeeName, string EmployeePhone, string DrivingLicenceTime);

        int AddConsignor(ViewConsignor obj);

        int DelConsignor(string ConsignorID);

        int UpdConsignor(ViewConsignor obj);
    }
}
