/*
 * 
 * Date:2014-10
 * 
 * Author:Mai_ZiJie
 * 
*/

using Microsoft.Practices.Unity;
using SDM.WinClient;
using SDM.WinClient.Common;
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
            UCResigter(GlobalMenus.container);
        }
        private static IUnityContainer UCResigter(IUnityContainer container)
        {
            #region 注册窗体
            container.RegisterType<BaseForm, Frm_Login>("Frm_Login");
            #endregion
            return container;
        }
    }
}
