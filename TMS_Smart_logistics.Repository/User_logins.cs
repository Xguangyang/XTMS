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
    public class User_logins : Base<UserModel>, ILogin
    {
        public List<UserModel> Logins(string UserName, string UserPwd)
        {
            DynamicParameters User = new DynamicParameters();
            User.Add("UserName", UserName);
            User.Add("UserPwd", UserPwd);
            // User.Add()
            string sql = "select * from UserModel where UserName=@UserName and UserPwd=@UserPwd";
           

            return Index(sql, User);
        }
    }
}
