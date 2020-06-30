using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.BLL.BLL_Interface
{
    public interface ICreateSha256Pwd
    {
        string CreateSHA256Code(string text);
    }
}
