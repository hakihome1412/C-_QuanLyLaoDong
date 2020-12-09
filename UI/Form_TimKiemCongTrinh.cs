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
using Entities;
using BLL;

namespace UI
{
    public partial class Form_TimKiemCongTrinh : DevExpress.XtraEditors.XtraForm
    {
        CongTrinhBLL ctBLL;
        public Form_TimKiemCongTrinh()
        {
            InitializeComponent();
            ctBLL = new CongTrinhBLL();

            dataGridView1.AutoGenerateColumns = false;
        }

        private void tbTenCongTrinh_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbTenCongTrinh_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(tbTenCongTrinh.Text))
                {
                    row.Selected = true;
                }
            }
        }

        private void loadDataCongTrinh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ctBLL.getAllCongTrinh();
        }

        private void Form_TimKiemCongTrinh_Load(object sender, EventArgs e)
        {
            loadDataCongTrinh();
        }

        private void Form_TimKiemCongTrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_TimKiemCongTrinh = true;
        }
    }
}