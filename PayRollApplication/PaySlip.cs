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
    public partial class PaySlip : Form
    {
        public PaySlip()
        {
            InitializeComponent();
        }


        public void PrintEmployeeData(int EmployeeId, string FirstName, string LastName,
            string ssnitNo, string Paydate, string PayMonth, string BasicSalary,
            string SsnitEmployee, string SsnitEmployer, string Housing, string Transport,
            string Dressing, string TotalEarning, string IncomeTax, string TotalDeduction, string NetSalary)
        {
            _valEmployeeID.Text = EmployeeId.ToString();
            _valFirstName.Text =  FirstName;
            _valLastName.Text = LastName;
            _valSsnitNumber.Text = ssnitNo;
            _valPayDate.Text = Paydate.ToString();
            _valPayMonth.Text = PayMonth.ToString();
            _valBasicSalary.Text = BasicSalary;
            _valSsnitEmployee.Text = SsnitEmployee;
            _valSsintEmployer.Text = SsnitEmployer;
            _valHousing.Text = Housing;
            _valTransport.Text = Transport;
            _valDressing.Text = Dressing;
            _valTotalEarning.Text = TotalEarning;
            _valIncomeTax.Text = IncomeTax;
            _valTotalDeduction.Text = TotalDeduction;
            _valNetSalary.Text = NetSalary;
        }
        private void PaySlip_Load(object sender, EventArgs e)
        {
            

        }

        private void groupBoxPaySlip_Enter(object sender, EventArgs e)
        {

        }
    }
}
