using StudentInformationManagerSystem.DAL.BaseClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StudentInformationManagerSystem.DAL.ModelDAL
{
    public class T_UserDAl:SqlHelper
    {
        /// <summary>
        /// 快速验证账号登录是否成功,并返回权限级别
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="Sha256pwd">sha256加密后的密码</param>
        /// <returns>返回权限级别</returns>
        public object ValidateAccount(string account, string Sha256pwd) {
            string t_sql = "select UserAuthority from T_User where T_User.UserID=@uid  and T_User.UserPwd=@pwd";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@uid", SqlDbType.VarChar, 15) { Value=account},
                new SqlParameter("pwd",SqlDbType.VarChar){ Value=Sha256pwd}
            };
            object authority=ExecuteScalar(t_sql, cmdType: CommandType.Text, pars);
            return authority;
        }
        public bool UpdatePassword(string userId,string password)
        {
            string t_sql = "updatePassword";
            SqlParameter[] pars = new SqlParameter[] {
                new SqlParameter("@userID",SqlDbType.VarChar,15){Value=userId },
                new SqlParameter("@newPassword",SqlDbType.VarChar){Value=password }
            };
            SqlHelper helper = new SqlHelper();
            return (int)helper.ExecuteScalar(t_sql, CommandType.StoredProcedure, pars) == 1;
        }
    }
}
