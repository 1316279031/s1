using StudentInformationManagerSystem.DAL.BaseClass;
using StudentInformationManagerSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentInformationManagerSystem.DAL
{
    public class T_TeachDAL
    {
        /// <summary>
        /// 查询教师ID、教师名
        /// </summary>
        /// <returns></returns>
        public List<T_Teach> GetTeches()
        {
            string t_sql = "select TeacherID,TeacherName from T_Teach";
            SqlHelper sql = new SqlHelper();
            List<T_Teach> teaches = null;
            using (SqlDataReader reader = sql.ExecuteReader(t_sql, System.Data.CommandType.Text))
            {
                if (reader.HasRows)
                {
                    teaches = new List<T_Teach>();
                    while (reader.Read())
                    {
                        teaches.Add(new T_Teach() {TeachID= reader.GetInt32(0),TeachName=reader.GetString(1) });
                    }
                }
            }
            return teaches;
        }
        /// <summary>
        /// 查询教师ID、教师名、教师性别、教师出身日期
        /// </summary>
        /// <param name="curIndex"></param>
        /// <param name="dataLength"></param>
        /// <param name="teachID"></param>
        /// <param name="teacherName"></param>
        /// <returns></returns>
        public List<T_Teach> GetTeches(int curIndex, int dataLength, string teachID, string teacherName) {
            SqlHelper hel = new SqlHelper();
            string t_sql = "Select_TeachsPagration";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@curIndex",SqlDbType.Int){Value=curIndex },
                new SqlParameter("@dataLength",SqlDbType.Int){Value=dataLength },
                new SqlParameter("@teacherID",SqlDbType.VarChar){Value="%"+teachID+"%"},
                new SqlParameter("@teacherName",SqlDbType.VarChar){Value="%"+teacherName+"%"}
            };
            List<T_Teach> teaches = null;
            using (SqlDataReader reader = hel.ExecuteReader(t_sql,CommandType.StoredProcedure,pars))
            {
                if (reader.HasRows)
                {
                    teaches = new List<T_Teach>();
                    while (reader.Read()) {
                        T_Teach teach = new T_Teach();
                        teach.TeachID=reader.GetInt32(0);
                        teach.TeachName = reader.GetString(1);
                        teach._sex = reader.GetBoolean(2);
                        teach.BirthDay =reader.GetDateTime(3).ToString("yyyy-MM-dd");
                        teaches.Add(teach);
                    }
                }
            }
            return teaches;
        }
        /// <summary>
        /// 跟新T_Teach数据
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public bool UpdateTeachData(string[] values)
        {

            string t_sql = "UpdateT_Teach";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@teachName",SqlDbType.VarChar,20){Value=values[0] },
                new SqlParameter("@sex",SqlDbType.Bit){Value=Convert.ToInt32(values[1]) },
                new SqlParameter("@birthDay",SqlDbType.Date){Value=values[2] },
                new SqlParameter("@teachID",SqlDbType.Int){Value=values[3] },
            };
            SqlHelper helper = new SqlHelper();
            return (int)helper.ExecuteScalar(t_sql, CommandType.StoredProcedure, pars) == 1;
        }

        /// <summary>
        /// 查询教师的学生考试成绩
        /// </summary>
        /// <param name="curIndex"></param>
        /// <param name="dataLength"></param>
        /// <param name="teachID"></param>
        /// <returns></returns>
        public List<Teach_s_StudentCourseFraction> GetTeach_S_StudentCourseFractions(int curIndex,int dataLength,string teachID)
        {
            string t_sql="SelectT_TeachStudentFaction";
            SqlParameter[] pars = new SqlParameter[]{
                new SqlParameter("@curIndex",SqlDbType.Int){Value=curIndex},
                new SqlParameter("@dataLength",SqlDbType.Int){Value=dataLength },
                new SqlParameter("@teachid",SqlDbType.Int){Value=teachID }
            };
            SqlHelper helper = new SqlHelper();
            List<Teach_s_StudentCourseFraction> res=null;
            using (SqlDataReader reader = helper.ExecuteReader(t_sql, CommandType.StoredProcedure, pars))
            {
                if (reader.HasRows)
                {
                    res = new List<Teach_s_StudentCourseFraction>();
                    while (reader.Read()) {
                        Teach_s_StudentCourseFraction fraction = new Teach_s_StudentCourseFraction();
                        fraction.StuID = reader.GetInt32(0);
                        fraction.StuName = reader.GetString(1);
                        fraction.ClassName = reader.GetString(2);
                        fraction.CourseName = reader.GetString(3);
                        fraction.TeachName = reader.GetString(4);
                        fraction.Faction = reader.IsDBNull(5) ? 0 : float.Parse(reader.GetValue(5).ToString());
                        res.Add(fraction);
                    }
                }
            }
            return res;
        }
        public bool DeleteT_TeachData(int teachId) {
            string t_sql = "Delete_Teach";
            SqlParameter par = new SqlParameter("@teachId", SqlDbType.Int) { Value = teachId };
            SqlHelper helper = new SqlHelper();
            return (int)helper.ExecuteScalar(t_sql, CommandType.StoredProcedure, par)==1;
        }
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="values">[0]:姓名 [1]:性别 [2]:性别</param>
        /// <returns>返回是否已插入</returns>
        public bool InsteredTeachData(string[] values)
        {
            string t_sql = "InsetertedT_Teach";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@teachName",SqlDbType.VarChar,20){Value=values[0] },
                new SqlParameter("@sex",SqlDbType.Bit){Value=Convert.ToInt32(values[1]) },
                new SqlParameter("@birthDay",SqlDbType.Date){Value=values[2] },
            };
            SqlHelper helper = new SqlHelper();
            return (int)helper.ExecuteScalar(t_sql, CommandType.StoredProcedure, pars)==1;
        }
    }
}
