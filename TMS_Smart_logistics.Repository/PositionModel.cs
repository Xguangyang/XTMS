using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.IRepository;
using TMS_Smart_logistics.Model;
using Dapper;

namespace TMS_Smart_logistics.Repository
{

    /// <summary>
    /// 职位操作
    /// </summary>
    public class PositionModel : Base<Model.PositionModel>, IPositionModel
    {
        public List<Model.PositionModel> GetPosition(string PositionName)
        {
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("PositionName", PositionName);

            string sql = "select * from PositionModel where PositionName like concat('%',@PositionName,'%')";
            return Index(sql, dynamic);
        }
    }
}
