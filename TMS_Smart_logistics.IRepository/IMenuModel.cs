using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.IRepository;
using TMS_Smart_logistics.Model;

namespace TMS_Smart_logistics.IRepository
{
   public interface IMenuModel:IBase<Model.MenuModel>
    {
        List<Model.MenuModel> GetMenu();
    }
}
