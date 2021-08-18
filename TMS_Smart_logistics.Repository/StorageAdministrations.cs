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
    public class StorageAdministrations : Base<Model.StorageAdministration>, IStorageAdministration
    {

        public int AddStorageID(StorageAdministration obj)
        {
            throw new NotImplementedException();
        }

        public int DelStorages(string StorageID)
        {
            throw new NotImplementedException();
        }

        public List<StorageAdministration> GetStorages()
        {
            string sql = "select * from StorageAdministration";
            return Index(sql);
        }

        public int UpdStorages(StorageAdministration onj)
        {
            throw new NotImplementedException();
        }
    }
}
