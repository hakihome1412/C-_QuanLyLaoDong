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
    public partial class Form_ThongTinCaNhan : DevExpress.XtraEditors.XtraForm
    {
        public Form_ThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_ThongTinCaNhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_ThongTinCaNhan = true;
        }
    }
}