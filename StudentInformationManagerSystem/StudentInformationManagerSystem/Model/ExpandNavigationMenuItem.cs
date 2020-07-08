using HZH_Controls.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationManagerSystem.Model
{
    /// <summary>
    /// 扩展导航菜单控件Click事件
    /// </summary>
    public class ExpandNavigationMenuItem: NavigationMenuItem
    {
        /// <summary>
        /// 扩展事件
        /// </summary>
        public event EventHandler Click;
        /// 触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Start(object sender,EventArgs args) {
            Click(sender,args);
        }
    }
}
