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
    public class RoleModel : Base<Model.RoleModel>, IRoleModel
    {
        public List<Model.RoleModel> GetRole(string RoleName)
        {
            DynamicParameters Data = new DynamicParameters();
            Data.Add("RoleName", RoleName);
            string sql = "select * from RoleModel where RoleName like concat('%',@RoleName,'%')";
            return Index(sql, Data);
        }
    }
}
