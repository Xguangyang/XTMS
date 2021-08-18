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
    public class AidRecipients : Base<ViewAidRecipients>, IViewAidRecipients
    {
        public List<ViewAidRecipients> GetAidRecipients()
        {
            DynamicParameters dynamic = new DynamicParameters();

            string sql = "select b.AidRecipientsID,	b.AidRecipientsTitle,	b.AidRecipientsContent,	b.Proposer,	b.ProposerTime,	b.Remark,	b.CreateTime,	c.ExamineStatus,	c.ExamineName from AidRecipientsExamine a join AidRecipients b on a.AidRecipientsID = b.AidRecipientsID join ExamineModel c on a.ExamineID = c.ExamineID";
            return Index(sql);
        }

        int IViewAidRecipients.AddAidRecipients(ViewAidRecipients obj)
        {
            string sql = "";
            return Exc(sql);
        }

        int IViewAidRecipients.DelAidRecipients(string ConsignorID)
        {
            string sql = "";
            return Exc(sql);
        }

        int IViewAidRecipients.UpdAidRecipients(ViewAidRecipients obj)
        {
            string sql = "";
            return Exc(sql);
        }
        
    }
}
