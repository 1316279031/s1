using HZH_Controls.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationManagerSystem.Model
{
    public class ExpandMenuItemEntity: MenuItemEntity
    {
        public event EventHandler Click;
        public void Start(object sender,EventArgs args) {
            Click(sender, args);
        }
    }
}
