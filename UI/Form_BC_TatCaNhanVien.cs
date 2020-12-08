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
using BLL;
using Entities;

namespace UI
{
    public partial class Form_BC_TatCaNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public Form_BC_TatCaNhanVien()
        {
            InitializeComponent();
        }

        public void PrintNhanVien(string tenPhongBan, List<eNhanVien> list)
        {
            ReportTatCaNhanVien report = new ReportTatCaNhanVien();

            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;

            report.initData(tenPhongBan, list);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        private void Form_BC_TatCaNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Main.f_BC_TatCaNhanVien = true;
    }
    }
}