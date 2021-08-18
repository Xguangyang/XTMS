using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.Model;
using TMS_Smart_logistics.IRepository;

namespace TMS_Smart_logistics.IRepository
{
   public interface IViewAidRecipients:IBase<ViewAidRecipients>
    {
        /// <summary>
        /// 物资领用显示
        /// </summary>
        /// <returns></returns>
        List<ViewAidRecipients> GetAidRecipients();
        /// <summary>
        /// 物资领用添加
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

       public int AddAidRecipients(ViewAidRecipients obj);
        /// <summary>
        /// 物资删除
        /// </summary>
        /// <param name="ConsignorID"></param>
        /// <returns></returns>

       public int DelAidRecipients(string ConsignorID);
        /// <summary>
        /// 物资修改
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

       public int UpdAidRecipients(ViewAidRecipients obj);
    }
}
