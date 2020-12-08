using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Entities;
using System.Collections.Generic;

namespace UI
{
    public partial class ReportTatCaNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportTatCaNhanVien()
        {
            InitializeComponent();
        }

        public void initData(string tenPhongBan, List<eNhanVien> list)
        {
            pTenPhongBan.Value = tenPhongBan;
            objectDataSource6.DataSource = list;
        }

    }
}
