using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.Model
{
    public class T_Teach
    {
        [DisplayName("编号")]
        public int TeachID { get; set; }
        [DisplayName("教师名")]
        public string TeachName { get; set; }
        [DisplayName("出生日期")]
        public string BirthDay { get; set; }
        public bool _sex;
        //如果说_sex=true则为男，否则为女
        [DisplayName("性别")]
        public string Sex { get {
                return _sex ? "男" : "女";  
            } }
        public override string ToString()
        {
            return TeachName;
        }
    }
}
