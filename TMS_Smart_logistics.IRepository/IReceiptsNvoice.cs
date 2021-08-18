using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.Model;

namespace TMS_Smart_logistics.IRepository
{
   public interface IReceiptsNvoice:IBase<Model.ReceiptsNvoice>
    {
        /// <summary>
        ///  进项发票 显示
        /// </summary>
        /// <returns></returns>
        List<Model.ReceiptsNvoice> GetDepartment();
        /// <summary>
        /// 进项添加
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        int AddReceiptsNvoice(Model.ReceiptsNvoice obj);
        /// <summary>
        /// 进项删除
        /// </summary>
        /// <param name="ReceiptsNvoiceID"></param>
        /// <returns></returns>
        int DelReceiptsNvoice(int ReceiptsNvoiceID);
        /// <summary>
        /// 进项修改
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        int UpdReceiptsNvoice(Model.ReceiptsNvoice obj);
    }
}
