using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.Model
{
    public class T_Student
    {
        public int StuID { get; set; }
        public string StuName { get; set; }
        public string StuBirthday { get; set; }
        public bool StuSex_filed;
        public string StuSex { get {
                if (StuSex_filed) {
                    return "男";
                }
                else
                {
                    return "女";
                }
            }}
        public int ClassID { get; set; }
        public T_Student() { 
        
        }
        public T_Student(int stuid, string stuname, string stubir,bool stusex, int classid) {
            StuID = stuid;
            StuName = stuname;
            StuBirthday = stubir;
            StuSex_filed = stusex;
            ClassID = classid;
        }
    }
}
