using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.Model
{
    public class T_Teach
    {
        public int TeachID { get; set; }
        public string TeachName { get; set; }
        public override string ToString()
        {
            return TeachName;
        }
    }
}
