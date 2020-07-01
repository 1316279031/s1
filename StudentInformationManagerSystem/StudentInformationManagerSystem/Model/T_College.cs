using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.Model
{
    public class T_College
    {
        public int CollegeID{get;set;}
        public string CollegeName { get; set;}
        public T_College() { 
        
        }
        public T_College(int collegeID,string collegeName)
        {
            CollegeID = collegeID;
            CollegeName = collegeName;
        }
    }
}
