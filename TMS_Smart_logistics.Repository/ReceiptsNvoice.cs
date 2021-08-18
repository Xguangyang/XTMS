using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.Model;
using TMS_Smart_logistics.IRepository;

namespace TMS_Smart_logistics.Repository
{
    public class ReceiptsNvoice : Base<Model.ReceiptsNvoice>, IReceiptsNvoice
    {
        public int AddReceiptsNvoice(Model.ReceiptsNvoice obj)
        {
            throw new NotImplementedException();
        }

        public int DelReceiptsNvoice(int ReceiptsNvoiceID)
        {
            throw new NotImplementedException();
        }

        public List<Model.ReceiptsNvoice> GetDepartment()
        {
            string sql = "select * from ReceiptsNvoice";
            return Index(sql);
        }

        public int UpdReceiptsNvoice(Model.ReceiptsNvoice obj)
        {
            throw new NotImplementedException();
        }
    }
}
