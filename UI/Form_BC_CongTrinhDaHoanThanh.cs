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

namespace UI
{
    public partial class Form_BC_CongTrinhDaHoanThanh : DevExpress.XtraEditors.XtraForm
    {
        public Form_BC_CongTrinhDaHoanThanh()
        {
            InitializeComponent();
        }

        private void Form_BC_CongTrinhDaHoanThanh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_BC_CongTrinhDaHoanThanh = true;
        }
    }
}