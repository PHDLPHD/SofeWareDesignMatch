using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDM.WinClient
{
    public class SkinMenus : LookAndFeelMenu
    {
        public SkinMenus(BarManager manager, DefaultLookAndFeel lookAndFeel, string about)
            : base(manager, lookAndFeel, about)
        {
        }
        public BarButtonItem SkinMenu
        {
            get
            {
                return this.miSkin;
            }
        }
    }
}
