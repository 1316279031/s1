using StudentInformationManagerSystem.DAL.ModelDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.BLL
{
    public class T_UserBll : ModelExecuteiionOption
    {
        T_UserDAl dal;
        public T_UserBll()
        {
            dal = new T_UserDAl();

        }
        public override bool DeleteDataInforMation(int id)
        {
            return false;
        }

        public override bool InsertedInforMation(string[] values)
        {
            return false;
        }
        /// <summary>
        /// modelID=-1:表示验证账户
        /// </summary>
        /// <param name="modelID"></param>
        /// <param name="curIndex"></param>
        /// <param name="dataLength"></param>
        /// <param name="pars"></param>
        /// <returns></returns>
        public override object ModelOptionLoad(int modelID, int curIndex, int dataLength, params string[] pars)
        {
            object res=null;
            //modelID=-1:表示验证账户
            switch (modelID)
            {
                case -1: {
                        res = dal.ValidateAccount(pars[0], pars[1]); 
                    };break;
                default:break;
            }
            return res;
        }

        public override bool UpdateInformation(string[] values)
        {
            return false;
        }
        public bool UpdatePassword(string userId,string password )
        {
            return dal.UpdatePassword(userId,password);
        }
    }
}
