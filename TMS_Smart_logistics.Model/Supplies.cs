using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Smart_logistics.Model
{
   public class Supplies
    {
        public int GoodsAndMaterialsExamineID { get; set; }
        public string GoodsAndMaterialsName { get; set; } //货物名称
        public string GoodsAndMaterialsTypeName { get; set; }//类别名称
        public string TextureName { get; set; } //材质名称
        public string Specification { get; set; } //规格
        public string PlaceOfOrigin { get; set; } //产地
        public int GoodsNumber { get; set; } //数量
        public string GoodsContent { get; set; } //用途描述
        public string Proposer { get; set; } //申请人
        public DateTime WashPayTime { get; set; }//期望交付日期
        public string Remark { get; set; } //备注
        public DateTime CreateTime { get; set; }//审核时间
        public int ExamineStatus { get; set; } //审批状态
        public string ExamineName { get; set; } //审批人

    }
}
