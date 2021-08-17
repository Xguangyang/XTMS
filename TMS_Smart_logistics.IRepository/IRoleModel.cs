using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.Model;
using TMS_Smart_logistics.IRepository;

namespace TMS_Smart_logistics.IRepository
{
   public interface IRoleModel:IBase<Model.RoleModel>
    {
        List<Model.RoleModel> GetRole(string RoleName);
    }
}
