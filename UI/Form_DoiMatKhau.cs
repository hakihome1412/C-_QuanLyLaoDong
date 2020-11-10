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
    public partial class Form_DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public Form_DoiMatKhau()
        {
            InitializeComponent();
        }

        private void Form_DoiMatKhau_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void Form_DoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_DoiMatKhau = true;
        }
    }
}