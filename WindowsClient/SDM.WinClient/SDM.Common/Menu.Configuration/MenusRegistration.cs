/*
 * 
 * Date:2014-10
 * 
 * Author:Mai_ZiJie
 * 
*/

using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM.Common.Menu.Configuration
{
    /// <summary>
    /// 注册Menus
    /// </summary>
    public class MenusRegistration
    {
        public static void MenusResigter()
        {
            GlobalMenus.container = new UnityContainer();
        }
    }
}
