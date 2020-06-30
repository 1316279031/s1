using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StudentInformationManagerSystem.DAL.BaseClass
{
    public class SqlHelper
    {
        private string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        public int ExecuteNonQuery(string t_sql, CommandType cmdType, params SqlParameter[] pars)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(t_sql, con))
                {
                    if (pars != null)
                    {
                        cmd.Parameters.AddRange(pars);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public object ExecuteScalar(string t_sql, CommandType cmdType, params SqlParameter[] pars)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(t_sql, con))
                {
                    if (pars != null)
                    {
                        cmd.Parameters.AddRange(pars);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
        public SqlDataReader ExecuteReader(string t_sql, CommandType cmdType, params SqlParameter[] pars) {
            SqlConnection con = new SqlConnection(constr);
            using (SqlCommand cmd = new SqlCommand(t_sql,con)) {
                if (pars != null) {
                    cmd.Parameters.AddRange(pars);
                }
                try
                {
                    con.Open();
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch {
                    con.Dispose();
                    throw;
                }
            }
        }
        public DataTable ExecuteTable(string t_sql, CommandType cmdType, params SqlParameter[] pars) {
            using (SqlDataAdapter adapter = new SqlDataAdapter(t_sql,constr)) {
                if (pars != null) {
                    adapter.SelectCommand.Parameters.AddRange(pars);
                }
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
