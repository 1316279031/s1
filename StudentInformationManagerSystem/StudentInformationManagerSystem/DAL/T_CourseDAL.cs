using StudentInformationManagerSystem.DAL.BaseClass;
using StudentInformationManagerSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.DAL
{
    public class T_CourseDAL
    {
        public List<T_CourseName> ExecuteListCourseName(int curIndex,int dataLength,string courseName="")
        {
            string t_sql = "SelectCourseName";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@curIndex",SqlDbType.Int){Value=curIndex},
                new SqlParameter("@dataLength",SqlDbType.Int){Value=dataLength},
                new SqlParameter("@courseName",SqlDbType.VarChar){Value="%"+courseName+"%"},
            };
            SqlHelper helper = new SqlHelper();
            List<T_CourseName> res = null;
            using (SqlDataReader reader = helper.ExecuteReader(t_sql,CommandType.StoredProcedure, pars)) {
                if (reader.HasRows) {
                    res = new List<T_CourseName>();
                    while (reader.Read()) {
                        T_CourseName cs = new T_CourseName();
                        cs.CourseName = reader.GetString(0);
                        res.Add(cs);
                    }
                }
            }
            return res;
        }
        public List<T_Course> ExecuteT_Course(int curIndex,int dataLength,string courseName,string className,string teachName) {
            string t_sql = "SelectT_ClassCourse";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@curIndex",SqlDbType.Int){ Value=curIndex},
                new SqlParameter("@dataLength",SqlDbType.Int){ Value=dataLength},
                new SqlParameter("@courseName",SqlDbType.VarChar){ Value="%"+courseName+"%"},
                new SqlParameter("@className",SqlDbType.VarChar){ Value="%"+className+"%"},
                new SqlParameter("@teachName",SqlDbType.VarChar){ Value="%"+teachName+"%"}
            };
            SqlHelper helper = new SqlHelper();
            List<T_Course> res = null;
            using (SqlDataReader reader = helper.ExecuteReader(t_sql, CommandType.StoredProcedure, pars)) {
                if (reader.HasRows) {
                    res = new List<T_Course>();
                    while (reader.Read())
                    {
                        T_Course course = new T_Course();
                        course.classID = reader.GetInt32(0);
                        course.ClassName = reader.GetString(1);
                        course.CourseID = reader.GetInt32(2);
                        course.CourseName = reader.GetString(3);
                        course.teachID = reader.GetInt32(4);
                        course.TeachName = reader.GetString(5);
                        res.Add(course);
                    }
                }
            }
            return res;
        }
    }
}
