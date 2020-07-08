using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.Model
{
    public class T_CourseName
    {
        [DisplayName("课程ID")]
        public virtual int CourseID { get; set; }
        [DisplayName("课程名")]
        public virtual string CourseName { get; set; }
        public override string ToString()
        {
            return CourseName;
        }
    }
}
