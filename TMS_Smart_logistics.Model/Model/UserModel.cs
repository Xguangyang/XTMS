using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_Smart_logistics.Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class UserModel
    {
        public int UserID { get; set; }                           //用户主键自增不为空
        public string UserName { get; set; }                      //用户姓名
        public string UserPwd { get; set; }                       //用户密码
        public string UserSex { get; set; }                       //用户性别(1：男2：女)
        public string UserPhone { get; set; }                     //用户手机号
        public string UserEmail { get; set; }                     //用户邮箱
        public string UserIdentityCard { get; set; }              //用户身份证号
        public string UserHomePlace { get; set; }                 //用户家庭住址
        public Nullable<System.DateTime> UserBrithday { get; set; }//出生日期
        public string UserSchool { get; set; }                    //院校
        public string UseMajor { get; set; }                      //专业
        public string UserEducation { get; set; }                 //学历 1：小学2：初中3：高中4：大学本科5：研究生
        public string UserNation { get; set; }                    //民族
        public string UserNativePlace { get; set; }               //籍贯
        public string UserPoliticsStatus { get; set; }            //政治面貌(1：团员2：党员3：平民)
        public string UseMarriage { get; set; }                   //婚姻 1：已婚2：未婚3:不清楚
        public Nullable<int> UserStatus { get; set; }             //用户状态
    }
}


