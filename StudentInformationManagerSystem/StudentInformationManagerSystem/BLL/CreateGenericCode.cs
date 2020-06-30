using StudentInformationManagerSystem.BLL.BLL_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.BLL
{
    public class CreateGenericCode : ICreateValidateCode, ICreateSha256Pwd
    {
        /// <summary>
        /// 创建动态验证码
        /// </summary>
        /// <returns></returns>
        public string CreateMemoryValidateCode()
        {
            string str = "0123456789abcdefghigklmnopqrstuvwxyz";
            //1.首先进行随机数取得验证码
            StringBuilder builder = new StringBuilder();
            Random ran = new Random();
            for (int i = 0; i < 4; i++)
            {
                builder.Append(str.Substring(ran.Next
                    (0,35),1).ToUpper());
            }
            return builder.ToString();
        }
        /// <summary>
        /// 创建SHA256加密字符串
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string CreateSHA256Code(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256 sha = new SHA256CryptoServiceProvider();
            bytes=sha.ComputeHash(bytes);
            return BitConverter.ToString(bytes).Replace("-","");
        }
    }
}
