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
    
    public class RegistrationModel : Base<Model.RegistrationModel>, IRegistrationModel
    {
        public List<Model.RegistrationModel> GetRegistrations(string FactoryPlateModel, string LicensePlateNumber, string LicensePlateName, string SubordinateCompanies)
        {
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("FactoryPlateModel", FactoryPlateModel);
            dynamic.Add("LicensePlateNumber", LicensePlateNumber);
            dynamic.Add("LicensePlateName", LicensePlateName);
            dynamic.Add("SubordinateCompanies", SubordinateCompanies);
            string sql = "select * from RegistrationModel where FactoryPlateModel like concat('%',@FactoryPlateModel,'%') or LicensePlateNumber like concat('%',@LicensePlateNumber,'%') or LicensePlateName like concat('%',@LicensePlateName,'%') or SubordinateCompanies like concat('%',@SubordinateCompanies,'%')";
            return Index(sql, dynamic);
        }
    }
}
