using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Smart_logistics.Model
{
    /// <summary>
    /// 物资领用视图模型
    /// </summary>
   public class ViewAidRecipients
    {
        public int AidRecipientsID { get; set; }//物资领用ID
        public string AidRecipientsTitle { get; set; }//标题
        public string AidRecipientsContent { get; set; }//用途描述
        public string Proposer { get; set; }//领用人
        public DateTime ProposerTime { get; set; }//领用时间
        public string Remark { get; set; } //备注
        public DateTime CreateTime { get; set; }//创建时间
        public int ExamineStatus { get; set; }//审核状态
        public string ExamineName { get; set; }//审核人
    }
}
