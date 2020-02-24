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
    public partial class FormAllEmployeeReport : Form
    {
        public FormAllEmployeeReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void FormAllEmployeeReport_Load(object sender, EventArgs e)
        {
            var rpt = new AllEmployeeReport();
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
