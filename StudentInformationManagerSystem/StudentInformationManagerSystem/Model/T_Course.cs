using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.Model
{
    public class T_Course :T_CourseName{ 
        //字段用来存储不显示的内容
        //属性用来存储显示内容
        public override int CourseID { get => base.CourseID; set => base.CourseID = value; }
        public override string CourseName { get => base.CourseName; set => base.CourseName = value; }
        public int classID;
        [DisplayName("班级名")]
        public string ClassName { get; set; }
        public int teachID;
        [DisplayName("教师名")]
        public string TeachName { get; set; }
    }
}
