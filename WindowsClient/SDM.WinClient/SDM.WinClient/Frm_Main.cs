using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace SDM.WinClient
{
    public partial class Frm_Main : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Main()
        {
            InitializeComponent();
            SkinMenus skinMenus = new SkinMenus(barManager1, defaultLookAndFeel1, "");
            bar2.AddItem(skinMenus.SkinMenu);
            IpText.Caption = new Func<string>(() =>
            {
                Uri uri = new Uri("http://20140507.ip138.com/ic.asp");
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(uri);
                try
                {
                    using (Stream stream = req.GetResponse().GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            return Regex.Match(reader.ReadToEnd(), @"\[(?<IP>[0-9\.]*)\]").Value;
                        }
                    }
                }
                catch
                {
                    return "You are not connected to the network";
                }
            })();
            Frm_Login login = new Frm_Login();
            login.ShowDialog();
           
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
        }

        private void Btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Btn_About_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new Frm_About()).Show();
        }
    }
}