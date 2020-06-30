using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.Model
{
    public class T_User
    {
        //用户ID
        public string UserID { get; set; }
        //用户权限
        public int UserAuthority { get; set; }
        public T_User() { 
        
        }
        public T_User(String uid, int uAuthority) {
            UserID = uid;
            UserAuthority = uAuthority;
        }
    }
}
