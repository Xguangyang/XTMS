using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.Model;
using TMS_Smart_logistics.IRepository;
using Dapper;

namespace TMS_Smart_logistics.Repository
{
    public class Consignor : Base<ViewConsignor>, IConsignor
    {
        public List<ViewConsignor> GetViewConsignors(string EmployeeName, string EmployeePhone, string DrivingLicenceTime)
        {
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("EmployeeName", EmployeeName);
            dynamic.Add("EmployeePhone", EmployeePhone);
            dynamic.Add("DrivingLicenceTime", DrivingLicenceTime);
            string sql = "select b.EmployeeName,b.EmployeePhone,d.OutsourcingUnitName,d.OutsourcingUnitPlace,a.DrivingLicenceTime,a.DrivingLicenceImg,a.Remark,d.OutsourcingUnitCreateTime from OwnerOfCargo a join EmployeeModel b on a.OwnerOfCargoID = b.EmployeeID join RegistrationModel c on a.OwnerOfCargoID = c.RegistrationID join OutsourcingUnit d on a.OwnerOfCargoID = d.OutsourcingUnitID where b.EmployeeName like concat('%',@EmployeeName,'%') and b.EmployeePhone like concat('%',@EmployeePhone,'%') and a.DrivingLicenceTime like concat('%',@DrivingLicenceTime,'%')";
            return Index(sql, dynamic);
        }
        /// <summary>
        /// 添加货主信息
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        int IConsignor.AddConsignor(ViewConsignor obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 删除货主信息 批删
        /// </summary>
        /// <param name="ConsignorID"></param>
        /// <returns></returns>

        int IConsignor.DelConsignor(string ConsignorID)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 修改货主信息
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        int IConsignor.UpdConsignor(ViewConsignor obj)
        {
            throw new NotImplementedException();
        }
    }
}
