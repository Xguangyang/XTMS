using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.IRepository;
using TMS_Smart_logistics.Model;

namespace TMS_Smart_logistics.Repository
{
    public class PayAdministrations : Base<Model.PayAdministration>, IPayAdministration
    {
        public int AddPays(PayAdministration obj)
        {
            throw new NotImplementedException();
        }

        public int DelPays(string PayAdministrationID)
        {
            throw new NotImplementedException();
        }
        //显示应付
        public List<PayAdministration> GetPays()
        {
            string sql = "select * from PayAdministration";
            return Index(sql);
        }

        public int UpdPays(PayAdministration onj)
        {
            throw new NotImplementedException();
        }
    }
}
