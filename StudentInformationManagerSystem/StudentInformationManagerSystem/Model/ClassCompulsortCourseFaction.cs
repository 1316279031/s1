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
        public virtual int StuID { get; set; }
        [DisplayName("学生姓名")]
        public virtual string StuName { get; set; }
        [DisplayName("班级名称")]
        public virtual string ClassName { get; set; }
        [DisplayName("课程名")]
        public virtual string CourseName { get; set; }
        [DisplayName("考分")]
        public virtual float Faction { get; set; }
    }
}
