using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.Model
{
    public class Teach_s_StudentCourseFraction:ClassCompulsortCourseFaction
    {
        [DisplayName("学生姓名")]
        public override int StuID { get => base.StuID; set => base.StuID = value; }
        [DisplayName("学生姓名")]
        public override string StuName { get => base.StuName; set => base.StuName = value; }
        [DisplayName("班级名")]
        public override string ClassName { get => base.ClassName; set => base.ClassName = value; }
        [DisplayName("课程名")]
        public override string CourseName { get => base.CourseName; set => base.CourseName = value; }
        [DisplayName("教师名")]
        public string TeachName { get; set; }
        [DisplayName("课程名")]
        public override float Faction { get => base.Faction; set => base.Faction = value; }
    }
}
