using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.BLL
{
    public abstract class ModelExecuteiionOption
    {
        /// <summary>
        /// 根据模型ID选择执行不同的加载流程
        /// </summary>
        /// <param name="modelID"></param>
        /// <param name="pars"></param>
        /// <returns></returns>
        public abstract object ModelOptionLoad(int modelID,int curIndex,int dataLength,params string[] pars);
        public abstract bool DeleteDataInforMation(int id);
        public abstract bool InsertedInforMation(string[] values);
        public abstract bool UpdateInformation(string[] values);
    }
}
