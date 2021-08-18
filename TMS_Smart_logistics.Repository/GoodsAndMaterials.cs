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
    public class GoodsAndMaterials : Base<Supplies>, IGoodsAndMaterials
    {
        public List<Supplies> GetAndMaterials(string GoodsAndMaterialsName, string TextureName, string PlaceOfOrigin, string Proposer, string ExamineName)
        {
            DynamicParameters dynamic = new DynamicParameters();
            dynamic.Add("GoodsAndMaterialsName", GoodsAndMaterialsName);
            dynamic.Add("TextureName", TextureName);
            dynamic.Add("PlaceOfOrigin", PlaceOfOrigin);
            dynamic.Add("Proposer", Proposer);
            dynamic.Add("ExamineName", ExamineName);
            string sql = "select b.GoodsAndMaterialsName,d.GoodsAndMaterialsTypeName,e.TextureName,b.Specification,b.PlaceOfOrigin,b.GoodsNumber,b.GoodsContent,b.Proposer,b.WashPayTime,b.Remark,b.CreateTime,c.ExamineStatus,c.ExamineName from GoodsAndMaterialsExamine a join GoodsAndMaterials b on a.GoodsAndMaterialsID = b.GoodsAndMaterialsID join ExamineModel c on a.ExamineID = c.ExamineID join GoodsType d on a.TypeID = d.GoodsAndMaterialsTypeID join Texture e on a.TextureID = e.TextureID where GoodsAndMaterialsName like concat('%',@GoodsAndMaterialsName,'%') and TextureName like concat('%',@TextureName,'%') and PlaceOfOrigin like concat('%',@PlaceOfOrigin,'%') and Proposer like concat('%',@Proposer,'%') and ExamineName like concat('%',@ExamineName,'%') ";
            return Index(sql,dynamic);
        }

       public  int AddGoodsAndMaterials(Supplies obj)
        {
            throw new NotImplementedException();
        }

       public int DelGoodsAndMaterialst(int GoodsAndMaterialsExamineID)
        {
            throw new NotImplementedException();
        }

        public int UpdGoodsAndMaterials(int GoodsAndMaterialsExamineID)
        {
            throw new NotImplementedException();
        }
    }
}
