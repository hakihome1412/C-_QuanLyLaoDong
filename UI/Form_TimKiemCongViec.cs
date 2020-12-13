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
    public partial class Form_TimKiemCongViec : DevExpress.XtraEditors.XtraForm
    {
        CongViecBLL cvBLL;
        public Form_TimKiemCongViec()
        {
            InitializeComponent();

            cvBLL = new CongViecBLL();

            dataGridView1.AutoGenerateColumns = false;
        }

        private void tbTenCongViec_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(tbTenCongViec.Text))
                {
                    row.Selected = true;
                }
            }
        }

        private void loadDataCongViec()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cvBLL.getAllCongViec();
        }

        private void Form_TimKiemCongViec_Load(object sender, EventArgs e)
        {
            loadDataCongViec();
        }

        private void Form_TimKiemCongViec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_TimKiemCongViec = true;
        }
    }
}