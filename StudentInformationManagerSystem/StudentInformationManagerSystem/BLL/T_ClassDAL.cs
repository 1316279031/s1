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
    public class T_ClassDAL
    {
        public List<T_Class> LoadClass(int collegeID) {
            string t_sql = "Select_ClassRegex";
            SqlParameter par = new SqlParameter("@collegeID", SqlDbType.Int) { Value = collegeID };
            SqlHelper sqlhelper = new SqlHelper();
            List<T_Class> res = null;
            using (SqlDataReader reader = sqlhelper.ExecuteReader(t_sql, CommandType.StoredProcedure, par))
            {
                if (reader.HasRows)
                {
                    res = new List<T_Class>();
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var name = reader.GetString(1);
                        T_Class @class = new T_Class(id, name);
                        res.Add(@class);
                    }
                }
            }
            return res;
        }
    }
}
