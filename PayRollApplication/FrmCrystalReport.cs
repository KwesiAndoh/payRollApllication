using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollApplication
{
    public partial class FrmCrystalReport : Form
    {
        public FrmCrystalReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer3_Load(object sender, EventArgs e)
        {
            var rpt = new EmployeeListRPT();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void FrmCrystalReport_Load(object sender, EventArgs e)
        {
            var rpt = new EmployeeListRPT();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
