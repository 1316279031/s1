using StudentInformationManagerSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.BLL
{

    public class T_TeachBll: ModelExecuteiionOption
    {
        T_TeachDAL dal;
        public T_TeachBll() { 
            dal= new T_TeachDAL();
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override bool DeleteDataInforMation(int id)
        {
            return dal.DeleteT_TeachData(id);
        }

        public override bool InsertedInforMation(string[] values)
        {
            if (values == null) return false;
            return  dal.InsteredTeachData(values);
        }

    /// <summary>
    /// 根据modelID执行不同的分支
    /// </summary>
    /// <param name="modelID"></param>
    /// <param name="curIndex"></param>
    /// <param name="dataLength"></param>
    /// <param name="pars"></param>
    /// <returns></returns>
    public override object ModelOptionLoad(int modelID,int curIndex ,int dataLength, params string[] pars)
        {
            object res = null;
            switch (modelID)
            {
                //查询所有教师信息
                case -1:res = dal.GetTeches(curIndex, dataLength, string.Empty, string.Empty);break;
                case 0: res = dal.GetTeches(curIndex, dataLength, pars[0], pars[1]);break;
                case 1: res = dal.GetTeach_S_StudentCourseFractions(curIndex, dataLength,pars[0]);break;
                default: break;
            }
            return res;
        }

        public override bool UpdateInformation(string[] values)
        {
            return dal.UpdateTeachData(values);
        }
    }
}
