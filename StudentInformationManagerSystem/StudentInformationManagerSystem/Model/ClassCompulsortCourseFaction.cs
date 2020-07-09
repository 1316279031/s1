using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.Model
{
    public class ClassCompulsortCourseFaction
    {
        [DisplayName("学生编号")]
        public int StuID { get; set; }
        [DisplayName("学生姓名")]
        public string StuName { get; set; }
        [DisplayName("班级名称")]
        public string ClassName { get; set; }
        [DisplayName("课程名")]
        public string CourseName { get; set; }
        [DisplayName("考分")]
        public float Faction { get; set; }
    }
}
