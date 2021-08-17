
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
    public class DepartmentModel : Base<Model.DepartmentModel>, IDepartmentModel
    {
        //添加部门
        public int AddDeparMent(Model.DepartmentModel obj)
        {
         
                string sql = "insert into DepartmentModel values(@DepartmentName,@DepartmentParentID,@DepartmentCreateTime,@DepartmentStatus)";
                return Exc(sql, obj);
        }
        //删除部门
        int IDepartmentModel.DelDeparMent(int DeparMentID)
        {
            //防sql注入
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("DepartmentID", DeparMentID);

            string sql = "update DepartmentModel set DepartmentStatus=0 where DepartmentID=@DepartmentID";
            return Exc(sql, parameters);
        }
        //fantian
        Model.DepartmentModel IDepartmentModel.FunDEparment(int DeparMentID)
        {
            //防sql注入
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("DepartmentID", DeparMentID);

            string sql = $"select * from DepartmentModel where DepartmentID=@DepartmentID";
            return Edit(sql,parameters);
        }

        //显示查询 部门

        List<Model.DepartmentModel> IDepartmentModel.GetDepartment(string DeparName)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("DeparName", DeparName);

            string sql = "select * from DepartmentModel where [DepartmentName] like concat('%',@DeparName,'%') and DepartmentStatus=1";
             return Index(sql, parameters);
        }


    }
}
