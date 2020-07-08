using StudentInformationManagerSystem.DAL.BaseClass;
using StudentInformationManagerSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.DAL
{
    public class T_TeachDAL
    {
        public List<T_Teach> GetTeches()
        {
            string t_sql = "select TeacherID,TeacherName,Sex,BirthDay from T_Teach";
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
    }
}
