using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.Model
{
    public class T_CourseFaction
    {
        // s2.ID,s2.StuID,s2.StuName,s2.CourseName,s2.TeacherName,s2.Faction
        [DisplayName("编号")]
        public int ID { get; set; }
        [DisplayName("学生编号")]
        public int StuID { get; set; }
        [DisplayName("学生姓名")]
        public string StuName { get; set; }
        [DisplayName("课程名称")]
        public string CourseName { get; set; }
        [DisplayName("教师姓名")]
        public string TeacherName { get; set; }
        [DisplayName("考分")]
        public float Faction { get; set; }
    }
}
