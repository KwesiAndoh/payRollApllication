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
    public partial class FormPayrollMDI : Form
    {
        public FormPayrollMDI()
        {
            InitializeComponent();
        }
        
        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm objEmpForm = new EmployeeForm();
            objEmpForm.MdiParent = this;
            objEmpForm.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private EmployeeForm objEmpForm = null;
        private void manageEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (objEmpForm == null)
            {
                objEmpForm = new EmployeeForm();
                objEmpForm.MdiParent = this;
                objEmpForm.Show();
            }
            else
            {
                objEmpForm.Activate();
                objEmpForm.MdiParent = this;
                objEmpForm.FormClosed += ObjEmpForm_FormClosed; 
            }
        }

        private void ObjEmpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrystalReport frm = new FrmCrystalReport();
            frm.MdiParent = this;
            frm.Visible = true;
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void arrangeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void layoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormPayrollMDI_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void payRollCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllEmployeeReport report = new FormAllEmployeeReport();
            report.MdiParent = this;
            report.Visible = true;

        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormPayrollMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            // A message if a formMdi is unintentionaly closed
            DialogResult objResult = MessageBox.Show("are you sure you want to close  this application", "Form Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           if (objResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                frmLoginRole frm = new frmLoginRole();
                this.Hide();
                frm.Visible = true;
            }
        }

        private void payrolCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pay_Roll_Calculator payroll = new Pay_Roll_Calculator();
            payroll.MdiParent = this;
            payroll.Visible = true;
        }

        private void payRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEmployeeReport report1 = new AllEmployeeReport();
        } 
    }
}
