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
    public class VIewLines : Base<Model.VIewLine>, ICircuitAdministration
    {
        
        public List<Model.VIewLine> GetVIewLines(string CircuitName, string CircuitStartPlace, string CircuitEndPlace, string IsOutsource, string EmployeeName, string OutsourcingUnitName)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("CircuitName", CircuitName);
            parameters.Add("CircuitStartPlace", CircuitStartPlace);
            parameters.Add("CircuitEndPlace", CircuitEndPlace);
            parameters.Add("IsOutsource", IsOutsource);
            parameters.Add("EmployeeName", EmployeeName);
            parameters.Add("OutsourcingUnitName", OutsourcingUnitName);
            string sql = "select a.CircuitAdministrationID,a.CircuitName,a.CircuitStartPlace,a.CircuitEndPlace,a.IsOutsource,b.EmployeeName,b.EmployeePhone,c.OutsourcingUnitName,a.Remark,a.CreateTime,a.CircuitStatus from CircuitAdministration a " +
                "join EmployeeModel b on a.CircuitAdministrationID = b.EmployeeID join  OutsourcingUnit c on a.CircuitAdministrationID = c.OutsourcingUnitID where CircuitName like concat('%',@CircuitName,'%') and CircuitStartPlace like concat('%',@CircuitStartPlace,'%') and CircuitEndPlace like concat('%',@CircuitEndPlace,'%') and IsOutsource like concat('%',@IsOutsource,'%') and EmployeeName like concat('%',@EmployeeName,'%') and OutsourcingUnitName like concat('%',@OutsourcingUnitName,'%')";
            return Index(sql, parameters);
        }

       public int AddLines(Model.VIewLine obj)
        {
            throw new NotImplementedException();
        }

       public int DelLines(string CircuitAdministrationID)
        {
            throw new NotImplementedException();
        }

        public int UpdLines(Model.VIewLine onj)
        {
            throw new NotImplementedException();
        }
    }
}
