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

namespace SDM.WinClient
{
    public partial class Frm_About : DevExpress.XtraEditors.XtraForm
    {
        public Frm_About()
        {
            InitializeComponent();
        }

        private void Frm_About_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}