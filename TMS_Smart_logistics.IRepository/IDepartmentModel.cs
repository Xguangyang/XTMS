using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.Model;


namespace TMS_Smart_logistics.IRepository
{
    //部门接口
    public interface IDepartmentModel : IBase<Model.DepartmentModel>
    {
        List<DepartmentModel> GetDepartment(string DeparName);

        int AddDeparMent(Model.DepartmentModel obj);
        int DelDeparMent(int DeparMentID);

        Model.DepartmentModel FunDEparment(int DeparMentID);
    }

    
}
