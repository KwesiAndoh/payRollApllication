using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollApplication
{
    public partial class Pay_Roll_Calculator : Form
    {
        public Pay_Roll_Calculator()
        {
            InitializeComponent();
        }

        private string fullname;

        private void Calculator_Load(object sender, EventArgs e)
        {
            textBasicSalary.Text = "2500";
            textTransport.Text = "10";
            textDressing.Text = "10";
            textHousing.Text = "10";
            
            // TODO: This line of code loads data into the 'payRollSystemDBDataSet1.PayRecords' table. You can move, or remove it, as needed.
            this.payRecordsTableAdapter1.Fill(this.payRollSystemDBDataSet1.PayRecords);

        }
       
        /// <summary>
        /// VALIDATING EMPLOYEE INFO
        /// </summary>
        /// <returns></returns>
        public bool IsDataControlValidForEmpInfo()
        {
            if (string.IsNullOrEmpty(textEmployeeId.Text))
            {
                MessageBox.Show("Employee ID must be filled", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textEmployeeId.Focus();
                textEmployeeId.BackColor = Color.Beige;
                return false;
            }
          

            // First Name
            if (string.IsNullOrEmpty(textFirstName.Text))
            {
                MessageBox.Show("Employee First Name must be filled", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textFirstName.Focus();
                textFirstName.BackColor = Color.Beige;
                return false;
            }
          

            // Last Name
            if (string.IsNullOrEmpty(textLastName.Text))
            {
                MessageBox.Show("Employee Last Name must be filled", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textLastName.Focus();
                textLastName.BackColor = Color.Beige;
                return false;
            }
            

            // Ssnit Number 
            if (string.IsNullOrEmpty(textSsnitNumber.Text))
            {
                MessageBox.Show("Employee SSNIT must be filled", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSsnitNumber.Focus();
                textSsnitNumber.BackColor = Color.Beige;
                return false;
            }
           
            return true;
        }

       
        public bool IsDataControlValidForSalInfo()
        {
            if (string.IsNullOrEmpty(textTotalEarning.Text))
            {
                MessageBox.Show("Employee First Name must be filled", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textTotalEarning.Focus();
                textTotalEarning.BackColor = Color.Beige;
                return false;
            }
            else
            {
                textTotalEarning.BackColor = Color.Coral;
            }

            // VALIDATING BASIC SALARY
            if (string.IsNullOrEmpty(textBasicSalary.Text))
            {
                MessageBox.Show("Base Salary must be filled", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBasicSalary.Focus();
                textBasicSalary.BackColor = Color.Beige;
                return false;
            }
            else
            {
                textBasicSalary.BackColor = Color.Coral;
            }
            return true;
        }
        

        // Get Button
        private void buttonGet_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["PayRollApplication"].ConnectionString;

            SqlConnection objSqlConn = new SqlConnection(conn);

            objSqlConn.Open();
            string selectCommand = $"select FirstName, LastName, SSNIT from Employee where EmployeeId = {Convert.ToInt32(textEmployeeId.Text)}";
            SqlCommand objCommand = new SqlCommand(selectCommand, objSqlConn);
            try
            {
                SqlDataReader dr = objCommand.ExecuteReader();
                if (dr.Read())
                {
                    textFirstName.Text = dr[0].ToString();
                    textLastName.Text = dr[1].ToString();
                    textSsnitNumber.Text = dr[2].ToString();
                    _lblFullName.Text = textFirstName.Text+ " " + textLastName.Text;
                    _lblSystemDate.Text = DateTime.Now.ToString();
                }
                else
                {
                    MessageBox.Show("data not found", "Dat request Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}", "selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                objSqlConn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void dataGridViewEmployeeInf_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// RESET EMPLOYEE INFO & DEUCTION
        /// </summary>
        void ClearControl()
        {
            textEmployeeId.Text = string.Empty;
            textFirstName.Text = string.Empty;
            textLastName.Text = string.Empty;
            textSsnitNumber.Text = string.Empty;
            _lblSystemDate.Text = " ";
            comboBxPayMonth.SelectedIndex = 0;
            textBasicSalary.Text = string.Empty;
            textHousing.Text = string.Empty;
            textTransport.Text = string.Empty;
            textDressing.Text = string.Empty;
            textTotalEarning.Text = string.Empty;

            _textSsnitEmployee.Text = string.Empty;
            _textSsnitEmployer.Text = string.Empty;
            _textIncomeTax.Text = string.Empty;
            _textTotalDeduction.Text = string.Empty;
            _textnetSalary.Text = string.Empty;
            fullname = string.Empty;

            _SearchSSNITNo.Text = string.Empty;
            _SearchPaymentID.Text = string.Empty;
            _SearchFullName.Text = string.Empty;
        }
        
       
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControl();
        }


        /// <summary>
        /// CALCULATE DEDUCTIONS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetDeduction_Click(object sender, EventArgs e)
        {
            try
            {
                SsnitEmployee();
                SsnitEmployer();
                IncomeTax();
                TotalDeduction();
                NetSalary();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error{ex.Message}", "Data Entry Error ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        


       /// <summary>
       /// PRINT PREVIEW
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnPreview_Click(object sender, EventArgs e)
        {
            PaySlip payslipForm = new PaySlip();
            //payslipForm.PrintEmployeeData( textEmployeeId.Text, textFirstName.Text, textLastName.Text,
            //    textSsnitNumber.Text, dateTimePickerPayDate, comboBxPayMonth, textBasicSalary.Text,
            //    textSsnitEmployee.Text,textSsnitEmployer.Text,textHousing.Text, textTransport.Text,
            //    textDressing.Text, textTotalEarning.Text, textIncomeTax.Text, 
            //    textTotalDeduction.Text, textnetSalary.Text);
        }


        // For SAVING 
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            fullname = textFirstName.Text + " " + textLastName.Text;

            if (IsDataControlValidForEmpInfo())
            {
                    string conn = ConfigurationManager.ConnectionStrings["PayRollApplication"].ConnectionString;

                    SqlConnection objSqlConn = new SqlConnection(conn);
                   
                    string InsertCommand = "Insert into PayRecords ( EmployeeID, FullName, SSNITNumber, PayDate, PayMonth, BasicSalary, Housing, Transport, Dressing, TotalEarning,SSNITEmployee, SSNITEmployer, IncomeTax, TotalDeduction, NetSalary) " +
                    "values ( @EmployeeID, @FullName, @SSNITNumber, @PayDate, @PayMonth, @BasicSalary, @Housing, @Transport, @Dressing, @TotalEarning, @SSNITEmployee, @SSNITEmployer, @IncomeTax, @TotalDeduction, @NetSalary)";

                    SqlCommand sqlcommnd = new SqlCommand( InsertCommand, objSqlConn);

                    sqlcommnd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(textEmployeeId.Text));
                    sqlcommnd.Parameters.AddWithValue("@FullName", fullname);
                    sqlcommnd.Parameters.AddWithValue("@SSNITNumber", textSsnitNumber.Text);

                    sqlcommnd.Parameters.AddWithValue("@PayDate", _lblSystemDate.Text);
                    sqlcommnd.Parameters.AddWithValue("@PayMonth", comboBxPayMonth.SelectedItem);
                    sqlcommnd.Parameters.AddWithValue("@BasicSalary", Convert.ToDouble(textBasicSalary.Text) );
                    sqlcommnd.Parameters.AddWithValue("@Housing", Convert.ToDouble(textHousing.Text) );
                    sqlcommnd.Parameters.AddWithValue("@Transport", Convert.ToDouble(textTransport.Text) );
                    sqlcommnd.Parameters.AddWithValue("@Dressing", Convert.ToDouble(textDressing.Text) );
                    sqlcommnd.Parameters.AddWithValue("@TotalEarning", Convert.ToDouble(textTotalEarning.Text));

                    sqlcommnd.Parameters.AddWithValue("@SSNITEmployee",Convert.ToDouble(_textSsnitEmployee.Text));
                    sqlcommnd.Parameters.AddWithValue("@SSNITEmployer", Convert.ToDouble(_textSsnitEmployer.Text));
                    sqlcommnd.Parameters.AddWithValue("@IncomeTax", Convert.ToDouble(_textIncomeTax.Text));
                    sqlcommnd.Parameters.AddWithValue("@TotalDeduction", Convert.ToDouble(_textTotalDeduction.Text));
                    sqlcommnd.Parameters.AddWithValue("@NetSalary", Convert.ToDouble(_textnetSalary.Text));

                try
                {
                    objSqlConn.Open();
                    sqlcommnd.ExecuteNonQuery();
                    MessageBox.Show("Employee Inserted Successfully", "Insert Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.payRecordsTableAdapter1.Fill(this.payRollSystemDBDataSet1.PayRecords);

                    ClearControl();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Insert Error {ex.Message}", "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally { 
}
            }
        }


        /// <summary>
        /// SEARCH BUTTON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder searchStatement = new StringBuilder();
            try
            {
                // validating Payment Id
                if (_SearchPaymentID.Text.Length > 0)
                {
                    searchStatement.Append($"Convert( PaymentId, 'System.String' ) like '%{_SearchPaymentID.Text}%' ");
                }

                if (_SearchFullName.Text.Length > 0)
                {
                    if (searchStatement.Length > 0)
                    {
                        searchStatement.Append(" and ");
                    }
                    else
                    {
                        MessageBox.Show("Your Search is Incorrect");
                    }
                    searchStatement.Append($"FullName like '%{fullname}%' ");

                }
                employeeBindingSource.Filter = searchStatement.ToString();
                
                // Validating Employee Id
                if (textEmployeeId.Text.Length > 0)
                {
                    searchStatement.Append($"Convert( EmployeeID, 'System.String' ) like '%{textEmployeeId.Text}%' ");
                }

                // Validating Employee Id
                if (_SearchFullName.Text.Length > 0)
                {
                    searchStatement.Append($" FullName  like '%{fullname}%' ");
                }
                
                // Validating Ssnit Number
                if (_SearchSSNITNo.Text.Length > 0)
                {
                    searchStatement.Append($"Convert( SSNITNumber, 'System.String' ) like '%{textSsnitNumber.Text}%' ");
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Please there was an error{ex.Message}");
            }

            payRecordsBindingSource3.Filter = searchStatement.ToString();
        }

        private void grpBxEmployeeInfo_Enter(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// TOTAL EARNING
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        double TotalEarning;
        private void btnTotalEarning_Click(object sender, EventArgs e)
         {
            double BasicSalary = Convert.ToDouble(textBasicSalary.Text);
            double Housing = Convert.ToDouble(textHousing.Text);
            double Transport = Convert.ToDouble(textTransport.Text);
            double Dressing = Convert.ToDouble(textDressing.Text);
            if (string.IsNullOrEmpty(textHousing.Text) || string.IsNullOrEmpty(textTransport.Text) || string.IsNullOrEmpty(textDressing.Text))
            {
                Housing = 0;
                Transport = 0;
                Dressing = 0;
            }

            try
            {
                if (Housing >= 0 || Transport >= 0 || Dressing >= 0)
                {
                    TotalEarning = BasicSalary + Housing + Transport + Dressing;
                    textTotalEarning.Text = TotalEarning.ToString();
                }

                else
                {
                    Housing = 0;
                    Transport = 0;
                    Dressing = 0;
                    textTotalEarning.Text = BasicSalary.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}", "Calc Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// PAYSLIP PREVIEW
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPaySlip_Click(object sender, EventArgs e)
        {
            PaySlip payslip =  new PaySlip();
            payslip.PrintEmployeeData(
                Convert.ToInt32(textEmployeeId.Text),
                textFirstName.Text,
                textLastName.Text, 
                textSsnitNumber.Text, 
                _lblSystemDate.Text, 
                Convert.ToString(comboBxPayMonth.SelectedText),
                textBasicSalary.Text,
                _textSsnitEmployee.Text,
                _textSsnitEmployer.Text,
                textHousing.Text,
                textTransport.Text,
                textDressing.Text,
                textTotalEarning.Text,
                _textIncomeTax.Text,
                _textTotalDeduction.Text, 
                _textnetSalary.Text);

            payslip.ShowDialog();
        }

        
        private void payRecordsBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// SSNIT EMPLOYEE CALCULATION
        /// </summary>

        double ssnitWorker=0.00;
        private void SsnitEmployee()
        {
            totalEarnings = Convert.ToDouble(textTotalEarning.Text);
            ssnitWorker = totalEarnings * 0.055;
            _textSsnitEmployee.Text = ssnitWorker.ToString();
           // return ssnit;
            
        }


        /// <summary>
        /// SSNIT EMPLOYER CALCULATION
        /// </summary>
        public double SsnitEmployer()
        {
            double ssnit;
            totalEarnings = Convert.ToDouble(textTotalEarning.Text);
            ssnit = totalEarnings * 0.13;
            _textSsnitEmployer.Text = ssnit.ToString();
            return ssnit;
        }


        /// <summary>
        /// INCOME TAX CALCULATION
        /// </summary>
        static double totalEarnings;
        double tax;
        public double IncomeTax()
        {
            totalEarnings = Convert.ToDouble(textTotalEarning.Text);
            double basic = 288;
            double remainder1 = totalEarnings - basic;
            double remainder5 = totalEarnings - basic - 100 - 140 - 3000 - 16472;
            


            // first 288: No tax
            if (totalEarnings <= basic)
            {
                _textIncomeTax.Text = Convert.ToString(0);
            }// First Tax Deduction (Next Gh100): 5%
            else if (basic < totalEarnings && totalEarnings <= 388)
            {
                tax = 5;
                _textIncomeTax.Text = tax.ToString();
            }// Second Tax Deduction (Next Gh140): 5% + 10%
            else if (288 < totalEarnings && totalEarnings <= 528)
            {
                tax = 5 + 14;
                _textIncomeTax.Text = tax.ToString();
            }// third tax Deduction (Next Gh3000): 5% + 10% + 17%
            else if (528 < totalEarnings && totalEarnings <= 3528)
            {
                tax = 5 + 14 + 525;
                _textIncomeTax.Text = tax.ToString();
            }// Fourth tax Deduction (Next Gh16472): 5% + 10% + 17% + 25%
            else if (3528 < totalEarnings && totalEarnings <= 20000)
            {
                tax = 5 + 14 + 525 + 4118;
                _textIncomeTax.Text = tax.ToString();
            }// Fifth tax Deduction (Exceeding 20000): 5% + 10% + 17% + 25% + 30%
            else
            {
                tax = remainder5 * 0.20;
                _textIncomeTax.Text = tax.ToString();
            }
            return tax;
        }

        /// <summary>
        /// TOTAL DEDUCTION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TotalDeduction()
        { 
            double totalDeduct = double.Parse(_textSsnitEmployee.Text) + double.Parse(_textIncomeTax.Text);
            _textTotalDeduction.Text = totalDeduct.ToString();
        }
        private void textBasicSalary_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// NET SALARY
        /// </summary>
        /// 
        double netsalary;
        private void NetSalary()
        {
            netsalary = double.Parse(textTotalEarning.Text) - double.Parse(_textTotalDeduction.Text);
            _textnetSalary.Text = netsalary.ToString();
        }


        //implicit validation ****************************************************
        private bool isNumberOrBackSpace;
      
        private void textTotalEarning_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumberOrBackSpace = false;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                isNumberOrBackSpace = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textHousing_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumberOrBackSpace = false;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                isNumberOrBackSpace = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textTransport_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumberOrBackSpace = false;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                isNumberOrBackSpace = true;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void textDressing_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumberOrBackSpace = false;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                isNumberOrBackSpace = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textPaymentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumberOrBackSpace = false;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                isNumberOrBackSpace = true;
            }
            else
            {
                e.Handled = true;
            }
        }


        

        private void _SearchFullName_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAllEmployeeReport allEmpReport = new FormAllEmployeeReport();
            allEmpReport.Show();
        }

        private void PayRecordsdataGridViewOne_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PayRecordsdataGridViewOne.Rows.Count > 0)
            {
                _SearchPaymentID.Text = PayRecordsdataGridViewOne.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                textEmployeeId.Text = PayRecordsdataGridViewOne.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                _lblFullName.Text = PayRecordsdataGridViewOne.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                _SearchSSNITNo.Text = PayRecordsdataGridViewOne.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                _lblSystemDate.Text = PayRecordsdataGridViewOne.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                comboBxPayMonth.SelectedText = PayRecordsdataGridViewOne.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                textBasicSalary.Text = PayRecordsdataGridViewOne.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                textHousing.Text  = PayRecordsdataGridViewOne.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                textTransport.Text = PayRecordsdataGridViewOne.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                textDressing.Text = PayRecordsdataGridViewOne.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
                textTotalEarning.Text = PayRecordsdataGridViewOne.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
                _textSsnitEmployee.Text = PayRecordsdataGridViewOne.Rows[e.RowIndex].Cells[11].FormattedValue.ToString();
                _textSsnitEmployer.Text = PayRecordsdataGridViewOne.Rows[e.RowIndex].Cells[12].FormattedValue.ToString();
                _textIncomeTax.Text = PayRecordsdataGridViewOne.Rows[e.RowIndex].Cells[13].FormattedValue.ToString();
                _textTotalDeduction.Text = PayRecordsdataGridViewOne.Rows[e.RowIndex].Cells[14].FormattedValue.ToString();
                _textnetSalary.Text = PayRecordsdataGridViewOne.Rows[e.RowIndex].Cells[15].FormattedValue.ToString();
            }
        }

        private void btnResetDeduction_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void btnNetSalary_Click(object sender, EventArgs e)
        {

        }


        private void textEmployeeId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTotalEarning_TextChanged(object sender, EventArgs e)
        {

        }



        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void _textSsnitEmployer_Click(object sender, EventArgs e)
        {

        }

        private void textTransport_TextChanged(object sender, EventArgs e)
        {

        }

        private void textHousing_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
