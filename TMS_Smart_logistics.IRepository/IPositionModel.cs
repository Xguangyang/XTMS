using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Smart_logistics.IRepository
{
   public interface IPositionModel:IBase<Model.PositionModel>
    {
        List<Model.PositionModel> GetPosition(string PositionNam);
    }
}
