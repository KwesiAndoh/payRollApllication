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
    public partial class PreviewEmployeeForm : Form
    {
        public PreviewEmployeeForm()
        {
            InitializeComponent();
        }

        // Method  to preview  Employee Data
        public void PreviewEmpData(int employeeID, string firstName, string lastName, 
            string Gender, string ssnitNo, DateTime DOB, string maritalStatus, bool staffWelfare, 
            string address, string city, string country, string phoneNo,string email, string notes)
        {
            _lblEmployeeID.Text = employeeID.ToString();
            _lblFirstname.Text = firstName;
            _lblLastname.Text = lastName;
            _lblGender.Text = Gender;
            _lblSsnitNo.Text = ssnitNo;
            _lblDOB.Text = DOB.ToString();
            _lblMaritalStatus.Text = maritalStatus;
            _lblWelfare.Text = staffWelfare.ToString();
            _lblAddress.Text = address;
            _lblPhone.Text = phoneNo;
            _lblCity.Text = city;
            _lblCountry.Text = country;
            _lblEmail.Text = email;
            _lblNotes.Text = notes;
        }
        private void lblStaffWelfare_Click(object sender, EventArgs e)
        {

        }

        private void _EmployeeInfo_Enter(object sender, EventArgs e)
        {

        }

        internal void PreviewEmpData(int v, string text1, string text2, string gender, string text3, DateTime value, string maritalStatus, bool staffMember, string text4, string text5, object selectedValue, string text6, string text7, string text8)
        {
            throw new NotImplementedException();
        }

        private void lblLastname_Click(object sender, EventArgs e)
        {

        }

        private void lblDOB_Click(object sender, EventArgs e)
        {

        }

        private void lblMaritalStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblNotes_Click(object sender, EventArgs e)
        {

        }

        private void PreviewEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
