using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.Model
{
    public class T_Class
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public int CollegeID { get; set; }
        public T_Class() { 
        }
        public T_Class(int classID, string className) { 
            ClassID=classID;
            ClassName = className;
        }
        public T_Class(int classID, string className, int collegeID)
        {
            ClassID = classID;
            ClassName = className;
            CollegeID = collegeID;
        }
    }
}
