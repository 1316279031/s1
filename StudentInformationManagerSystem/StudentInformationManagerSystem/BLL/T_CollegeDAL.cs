using StudentInformationManagerSystem.DAL.BaseClass;
using StudentInformationManagerSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.BLL
{
    public class T_CollegeDAL
    {
        public List<T_College> LoadCollege() {
            string t_sql = "Select_College";
            SqlHelper sqlhelper = new SqlHelper();
            List<T_College> res = null;
            using (SqlDataReader reader = sqlhelper.ExecuteReader(t_sql, CommandType.StoredProcedure, null)) {
                if (reader.HasRows) {
                    res = new List<T_College>();
                    while (reader.Read()) {
                        var id = reader.GetInt32(0);
                        var name = reader.GetString(1);
                        T_College college = new T_College(id, name);
                        res.Add(college);
                    }
                }
            }
            return res;
        }
    }
}
