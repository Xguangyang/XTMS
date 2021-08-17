using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.IRepository;
using TMS_Smart_logistics.Model;
using Dapper;
using TMS_Smart_logistics.Common;

namespace TMS_Smart_logistics.Repository
{
    /// <summary>
    /// 基础实现类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Base<T> :IBase<T> where T : class, new()
    {

        IDbConnection conn = new SqlConnection(ConnString.connstring);

        //反填
        public T Edit(string sql, object obj = null)
        {

            return conn.Query<T>(sql, obj).SingleOrDefault();
        }

        //增删改
        public int Exc(string sql, object obj = null)
        {
            return conn.Execute(sql, obj);
        }

        //显示.查询
        public List<T> Index(string sql, object obj = null)
        {
            return conn.Query<T>(sql, obj).ToList();
        }

    }
}
