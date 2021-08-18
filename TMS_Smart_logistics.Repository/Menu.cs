using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.Model;
using TMS_Smart_logistics.IRepository;

namespace TMS_Smart_logistics.Repository
{
    public class Menu : Base<Model.MenuModel>, IMenuModel
    {
        /// <summary>
        /// 菜单
        /// </summary>
        /// <returns></returns>
        public List<MenuModel> GetMenu()
        {
            string sql = "select * from MenuModel";
            return Index(sql);
        }
    }
}
