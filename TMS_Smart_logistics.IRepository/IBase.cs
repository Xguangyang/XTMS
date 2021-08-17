using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Smart_logistics.IRepository
{
    /// <summary>
    /// 基础接口
    /// </summary>
    public interface IBase<T> where T:class,new ()
    {
        ///增删改
        int Exc(string sql,object obj=null);

        //显示
        List<T> Index(string sql, object obj = null);

        //反填
        T Edit(string sql, object obj = null);
    }
}
