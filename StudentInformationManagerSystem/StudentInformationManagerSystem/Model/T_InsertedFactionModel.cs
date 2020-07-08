using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.Model
{
   public class T_InsertedFactionModel
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public override string ToString()
        {
            return CourseName;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cid">课程ID</param>
        /// <param name="cname">课程名</param>
        /// <param name="tid">教师ID</param>
        /// <param name="tname">教师名</param>
        public T_InsertedFactionModel(int cid,string cname,int tid,string tname)
        {
            CourseID = cid;
            CourseName = cname;
            TeacherID = tid;
            TeacherName = tname;
        }
        public T_InsertedFactionModel()
        {

        }
    }
}
