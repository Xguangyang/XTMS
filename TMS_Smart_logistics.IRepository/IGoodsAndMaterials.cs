using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_Smart_logistics.IRepository;
using TMS_Smart_logistics.Model;
namespace TMS_Smart_logistics.IRepository
{
   public interface IGoodsAndMaterials:IBase<Supplies>
    {
        /// <summary>
        /// 物资采购管理
        /// </summary>
        /// <param name="GoodsAndMaterialsName"></param>
        /// <param name="TextureName"></param>
        /// <param name="PlaceOfOrigin"></param>
        /// <param name="Proposer"></param>
        /// <param name="ExamineName"></param>
        /// <returns></returns>
        List<Supplies> GetAndMaterials(string GoodsAndMaterialsName,string TextureName,string PlaceOfOrigin,string Proposer,string ExamineName);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        int AddGoodsAndMaterials(Supplies obj);
        int DelGoodsAndMaterialst(int GoodsAndMaterialsExamineID);

        int UpdGoodsAndMaterials(int GoodsAndMaterialsExamineID);
    }
}
