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
        /// <summary>
        /// 根据CollegeID查询
        /// </summary>
        /// <param name="collegeID"></param>
        /// <returns></returns>
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
                        var college = reader.GetInt32(2);
                        T_Class @class = new T_Class(id, name, college);
                        res.Add(@class);
                    }
                }
            }
            return res;
        }
        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        public List<T_Class> LoadClass()
        {
            string t_sql = "Select_Class";
            SqlHelper sqlhelper = new SqlHelper();
            List<T_Class> res = null; 
            using (SqlDataReader reader = sqlhelper.ExecuteReader(t_sql, CommandType.StoredProcedure))
            {
                if (reader.HasRows)
                {
                    res = new List<T_Class>();
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var name = reader.GetString(1);
                        var college = reader.GetInt32(2);
                        T_Class @class = new T_Class(id, name, college);
                        res.Add(@class);
                    }
                }
            }
            return res;
        }
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <returns></returns>
        public List<T_Class> LoadPagiation(int curIndex,int dataLength,int collegeID=-1)
        {
            string t_sql = "Select_ClassPagiation";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@curIndex",SqlDbType.Int){Value=curIndex},
                new SqlParameter("@dataLength",SqlDbType.Int){Value=dataLength },
                new SqlParameter("@collegeID",SqlDbType.Int){ Value=collegeID}
            };
            SqlHelper sqlhelper = new SqlHelper();
            List<T_Class> res = null;
            using (SqlDataReader reader = sqlhelper.ExecuteReader(t_sql, CommandType.StoredProcedure, pars))
            {
                if (reader.HasRows)
                {
                    res = new List<T_Class>();
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var name = reader.GetString(1);
                        var college = reader.GetInt32(2);
                        T_Class @class = new T_Class(id, name, college);
                        res.Add(@class);
                    }
                }
            }
            return res;
        }
        /// <summary>
        /// 发送SQL语句执行，并返回单个值
        /// </summary>
        /// <param name="t_sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="pars"></param>
        /// <returns></returns>
        public object ExecuteScalar(string t_sql, CommandType cmdType, params SqlParameter[] pars) {
            SqlHelper sqlHelper = new SqlHelper();
            return sqlHelper.ExecuteScalar(t_sql, cmdType, pars);
        }
    }
}
