using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.IRepository;
using TMS_Smart_logistics.Model;

namespace TMS_Smart_logistics.Repository
{
    public class Charges : Base<Model.Charge>, ICharge
    {
        public int AddCharge(Charge obj)
        {
            throw new NotImplementedException();
        }

        public int DelCharge(string ChargeId)
        {
            throw new NotImplementedException();
        }

        public List<Charge> GetCharges()
        {
            string sql = "select * from Charge";
            return Index(sql);
        }

        public int UpdCharge(Charge obj)
        {
            throw new NotImplementedException();
        }
    }
}
