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
using SDM.DTO;
using SDM.DTO.Main;

namespace SDM.WinClient.Common
{
    public partial class BaseForm : XtraForm
    {
        protected static User user{get;set;}
        protected event EventHandler saveEvent;
        public BaseForm()
        {
            InitializeComponent();
        }
    }
}