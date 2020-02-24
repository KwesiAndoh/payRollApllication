using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;

namespace PayRollApplication
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        // handling the gender, marital status country and staff welfare
        private string gender;
        private string maritalStatus;
        private string country;
        bool staffWelfare;

        // Regular expression*************************************************

        /*VALIDATING EMPLOYEE ID*/
        //1. type of character to match input against: must be only numbers
        //2. what is the  lenght of numbers: min =3 max =4
        Regex objEmployeeID = new Regex("^[0-9]{3,9}$");

        /*VALIDATINIG FIRST NAME AND LAST NAME*/
        //1. Capitals only
        //2. mixture of upper and lower
        //3. (*) Accept  any of the options supplied  
        Regex objFirstName = new Regex("^[A-Z][a-zA-Z]*$");
        Regex objLastName = new Regex("^[A-Z][a-zA-Z]*$");

        /*VALIDATINIG SSNIT NO*/
        //1. Capital letters only 
        //2. Numbers follows
        //3. Number length of 6
        Regex objSSNITNo = new Regex("^[a-z]{1,5}[0,9]{1,5} $");

        /*VALIDATINIG EMAIL*/
        //Regex objEmail = new Regex("^[a-zA-Z0-9)]{1,30}@[a-zA-Z0-9]{1,30}.[a-zA-Z]{2,4}$");
        Regex objEmail = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
        //Regex objEmail = new Regex(@^ (? (")(".+? (?< !\\)"@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$);

        // End  Regular expression------------------------------------------


        //Explicit Validation****************************************
        private bool isControlDataValid()
        {
            //Start Employee ID Validation****************************************
            if (Convert.ToInt32(txtEmployeeID.Text.Length) < 1)
            {
                MessageBox.Show("Please Enter EmployeeID", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                txtEmployeeID.BackColor = Color.Silver;
                return false;
            } //applying regular expression on the Emplyee ID
            else if (!objEmployeeID.IsMatch(txtEmployeeID.Text))
            {
                MessageBox.Show("Employee ID is not valid", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                txtEmployeeID.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtEmployeeID.BackColor = Color.White;
            }
            // End Employee ID Validation------------------------------------------

            // Start First Name Validation****************************************
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please Enter First Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                txtEmployeeID.BackColor = Color.Silver;
                return false;
            } // applying  regular expression on firt name 
            else if (objFirstName.IsMatch(txtFirstName.Text))
            {
                MessageBox.Show("First Name must start with Capital letter", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                txtFirstName.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtFirstName.BackColor = Color.White;
            }
            // End First Name Validation---------------------------------

            // Start Last Name Validation********************************
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please Enter Last Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                txtLastName.BackColor = Color.Silver;
                return false;
            }// applying validation on Last Name
            else if (objLastName.IsMatch(txtLastName.Text))
            {
                MessageBox.Show("Last Name must start with Capital letter", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                txtLastName.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtLastName.BackColor = Color.White;
            }
            // End Last Name Validation---------------------------------------

            // Start Gender Radio buttons********************************
            if (radioMale.Checked == false && radiofemale.Checked == false)
            {
                MessageBox.Show("Please select Male or female", "Gender Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                radioMale.Focus(); 
                radioMale.BackColor = Color.Wheat;
                radiofemale.BackColor = Color.Wheat;
                return false;
            }
            else
            {
                radioMale.BackColor = Color.Silver;
                radiofemale.BackColor = Color.Coral;
            }
            // End Gender Radio buttons---------------------------------------

            // Start SSNIT Validation****************************************
            if (Convert.ToInt32(txtSNNITNo.Text.Length) < 1)
            {
                MessageBox.Show("Please Enter SSNIT No.", "Data Entry  Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSNNITNo.Focus();
                txtSNNITNo.BackColor = Color.AliceBlue;
                return false;
            }
            else if (objSSNITNo.IsMatch(txtSNNITNo.Text))
            {
                MessageBox.Show("SSNIT Number is not valid", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSNNITNo.Focus();
                txtSNNITNo.BackColor = Color.AliceBlue;
                return false;
            }
            else
            {
                txtSNNITNo.BackColor = Color.White;
            }
            // End SSNIT Validation---------------------------------------


            // Start Date Of Birth****************************************
            //txtDateTimePicker.Value.ToString;txtDateTimePicker.Value.ToString
            // End Date of Birth---------------------------------------


            // Start Marital Status buttons****************************************
            if (radioSingle.Checked == false && radioMarried.Checked == false)
            {
                MessageBox.Show("Please select Single or Married", "Data Entry  Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                radioSingle.Focus();
                radioSingle.BackColor = Color.Wheat;
                radioMarried.BackColor = Color.Wheat;
                return false;
            }
            else
            {
                radioSingle.BackColor = Color.Silver;
                radioMarried.BackColor = Color.Coral;
            }
            // End Marital Status buttons


            // Start Address****************************************
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please Enter Address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                txtAddress.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtAddress.BackColor = Color.White;
            }
            // End Address

            // Start City****************************************
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("Please Enter City", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                txtCity.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtCity.BackColor = Color.White;
            }
            // End City

            // Start Country************************
            if (comboBoxCity.SelectedIndex == 0 || comboBoxCity.SelectedIndex == -1)
            {
                MessageBox.Show("Please  select Country", "Data  Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCity.Focus();
                return false;
            }
            // End Country

            //Start Phone************************
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please Enter Phone Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                txtPhoneNumber.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtPhoneNumber.BackColor = Color.White;
            }
            //End Phone

            // Start Email********************************
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please Enter Email", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                txtEmail.BackColor = Color.Silver;
                return false;
            }
            else if (!objEmail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Email Address is not complete", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                txtEmail.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }
            // End Email

            return true;
        }
        // end of explicit validation


        // handling the gender: for male or female to be passed to the preview form
        private void checkItems()
        {
            if (radioMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if (radioSingle.Checked)
            {
                maritalStatus = "Single";
            }
            else
            {
                maritalStatus = "Married";
            }

            if (checkBoxStaffWelfare.Checked )
            {
                staffWelfare = true;
            }

            country = Convert.ToString(comboBoxCity.SelectedItem);
        }


        //this will clear data from the form after each execution:
        // will be call in ADD, UPDATE, DELETE
        private void clearControl()
        {
            txtEmployeeID.Clear();
            txtFirstName.Text = "";
            txtLastName.Text = string.Empty;
            radioSingle.Checked = false;
            radioMarried.Checked = false;
            radioMale.Checked = false;
            radiofemale.Checked = false;
            txtSNNITNo.Clear();
            txtDateTimePicker.Value = new DateTime(2000, 01, 1);
            checkBoxStaffWelfare.Checked = false;
            txtAddress.Clear();
            txtCity.Clear();
            comboBoxCity.SelectedIndex = 0;
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtNotes.Clear();

        }


       
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payRollSystemDBDataSet4.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.payRollSystemDBDataSet4.Employee);
            // TODO: This line of code loads data into the 'payRollSystemDBDataSet.Employee' table. You can move, or remove it, as needed.
            //    this.employeeTableAdapter.Fill(this.payRollSystemDBDataSet.Employee);
            // Validating the ComboBox to automatically select the first item on the list.
            comboBoxCity.SelectedIndex = 0;
            btnDelete.Enabled = false;
        }

        //ADD: settings to push info into database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isControlDataValid())
            {
                checkItems();
                //1 SQL Connection
                // connection string: gotten from system. configuration
                string conn = ConfigurationManager.ConnectionStrings["PayRollApplication"].ConnectionString;

                // instantiate sqlconnection
                SqlConnection objSqlConn = new SqlConnection(conn);

                //2. SQL query
                try
                {
                    objSqlConn.Open();
                    string insertCommand = "insert into Employee values( " +
                        Convert.ToInt32(txtEmployeeID.Text) + ",'" +
                        txtFirstName.Text + "','" +
                        txtLastName.Text + "','" +
                        gender + "','" +
                        txtSNNITNo.Text + "','" +
                        txtDateTimePicker.Value.ToString("MM/dd/yy") + "','" +
                        maritalStatus + "','" +
                        txtAddress.Text + "','" +
                        txtCity.Text + "','" +
                        comboBoxCity.SelectedText + "','" +
                        txtPhoneNumber.Text + "','" +
                        txtEmail.Text + "','" +
                        txtNotes.Text + "','" + staffWelfare + "')";


                    //3. SQL Command
                    //instantiate  sql command and pass in query text and connection object
                    SqlCommand objCommand = new SqlCommand(insertCommand, objSqlConn);

                    //Execute the query with our commandText
                    objCommand.ExecuteNonQuery();

                    // message to display when our insert is successful
                    MessageBox.Show($"Employee with Id: {txtEmployeeID.Text} is added successfully", "Insert Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // The datagrid view automatically update after insert
               //     this.employeeTableAdapter.Fill(this.payRollSystemDBDataSet.Employee);

                    // the entry space is cleared after every successful insert
                    clearControl();
                }
                catch (Exception ex)
                {
                    // Message displayed when insertion is unsuccessful
                    MessageBox.Show($"Error {ex.Message}", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    // close database connection whether failure or success
                    objSqlConn.Close();
                }
            }
        }


        // UPDATE: to update an existing info in a database
        private void button1_Click(object sender, EventArgs e)
        {
            if (isControlDataValid())
            {
                checkItems();
                //1 SQL Connection
                // connection string: gotten from system. configuration
                string conn = ConfigurationManager.ConnectionStrings["PayRollApplication"].ConnectionString;

                // instantiate sqlconnection
                SqlConnection objSqlConn = new SqlConnection(conn);

                //2. SQL query
                try
                {
                    objSqlConn.Open();
                    String updateCommand = "Update Employee set " +
                "FirstName = '" + txtFirstName.Text +
                "', LastName ='" + txtLastName.Text +
                "', Gender ='" + this.gender +
                "', SSNIT ='" + txtSNNITNo.Text +
                "', DOB = '" + txtDateTimePicker.Value.ToString() +
                "', MaritalStatus = '" + this.maritalStatus +
                "', Address = '" + txtAddress.Text +
                "', City = '" + txtCity.Text +
                "', Country = '" + comboBoxCity.SelectedItem +
                "', PhoneNumber = '" + txtPhoneNumber.Text +
                "', Email ='" + txtEmail.Text +
                "', Notes = '" + txtNotes.Text +
                "', IsMember = '" + this.staffWelfare + 
                "' where employeeId = " + Convert.ToInt32(txtEmployeeID.Text);
                


                    //3. SQL Command
                    //instantiate  sql command and pass in command text and connection object
                    SqlCommand objCommand = new SqlCommand(updateCommand, objSqlConn);

                    //Execuate the query with our commandText
                    objCommand.ExecuteNonQuery();

                    // Shown when update is successful
                    MessageBox.Show($"Employee with Id: {txtEmployeeID.Text} is updated successfully", "update Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ComboBox is automatically Updated 
             //       this.employeeTableAdapter.Fill(this.payRollSystemDBDataSet.Employee);

                    // Clears textbox after every successful update  
                    clearControl();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error {ex.Message}", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    objSqlConn.Close();
                }
            }
        }


        // DELETE: 
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult objDialogResult = MessageBox.Show($"Are you sure you want to delete a record", "DELETE BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (objDialogResult == DialogResult.Yes)
            {
                // checkItems();
                //1 SQL Connection
                // connection string: gotten from system. configuration
                string conn = ConfigurationManager.ConnectionStrings["PayRollApplication"].ConnectionString;

                // instantiate sqlconnection
                SqlConnection objSqlConn = new SqlConnection(conn);

                //2. SQL query
                try
                {
                    objSqlConn.Open();
                    string DeleteCommand = $" Delete from Employee where EmployeeID = {Convert.ToInt32(txtEmployeeID.Text)} ";

                    //3. SQL Command
                    //instantiate  sql command and pass in command text and connection object
                    SqlCommand objCommand = new SqlCommand(DeleteCommand, objSqlConn);

                    //Execuate the query with our commandText
                    objCommand.ExecuteNonQuery();
                    MessageBox.Show($"Employee with Id: {txtEmployeeID.Text} is Deleted successfully", "Delete Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
          //          this.employeeTableAdapter.Fill(this.payRollSystemDBDataSet.Employee);

                    clearControl();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error {ex.Message}", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    objSqlConn.Close();
                }
            }
        }

        // EXIT:
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // PREVIEW: of the input information
        private void btnPreview_Click(object sender, EventArgs e)
        {
            checkItems();
            PreviewEmployeeForm frmPreview = new PreviewEmployeeForm();
            frmPreview.PreviewEmpData(Convert.ToInt32(txtEmployeeID.Text),
                txtFirstName.Text,
                txtLastName.Text,
                gender, 
                txtSNNITNo.Text,
                txtDateTimePicker.Value, 
                maritalStatus,
                staffWelfare, 
                txtAddress.Text, 
                txtCity.Text, 
                Convert.ToString(comboBoxCity.SelectedItem), 
                txtPhoneNumber.Text, 
                txtEmail.Text, 
                txtNotes.Text);

            frmPreview.ShowDialog();
        }

        // RESET: the values to initials
        private void bntReset_Click(object sender, EventArgs e)
        {
            clearControl();
        }


        // Implicit Validation for Employee ID
        private bool isNumberOrBackSpace;
        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
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


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (dataGridView1.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    txtEmployeeID.Text = row.Cells[0].ToString();
                }
            }
            */

            // for Gender
            if (gender == "Male")
            {
                radioMale.Checked = true;
                radiofemale.Checked = false;
            }
            else
            {
                radioMale.Checked = false;
                radiofemale.Checked = true;
            }

            // for marital status
            if (maritalStatus == "Single")
            {
                radioSingle.Checked = true;
                radioMarried.Checked = false;
            }
            else
            {
                radioSingle.Checked = false;
                radioMarried.Checked = true;
            }

            // for staff member
            if (staffWelfare)
            {
                checkBoxStaffWelfare.Checked = true;
            }
            txtEmployeeID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            gender = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtSNNITNo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtDateTimePicker.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString());
            maritalStatus = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
            txtCity.Text = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            comboBoxCity.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            txtPhoneNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[11].FormattedValue.ToString();
            txtNotes.Text = dataGridView1.Rows[e.RowIndex].Cells[12].FormattedValue.ToString();
            staffWelfare = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[13].FormattedValue.ToString());

            btnDelete.Enabled = true;
        }

        // GET: to retrieve a portion of data from the database
        private void btnGet_Click(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["PayRollApplication"].ConnectionString;
           
            SqlConnection objSqlConn = new SqlConnection(conn);

            objSqlConn.Open();
            string selectCommand = $"select FirstName, LastName from Employee where EmployeeId = {Convert.ToInt32(txtEmployeeID.Text)}";

            SqlCommand objCommand = new SqlCommand(selectCommand, objSqlConn);

            try
            {
                SqlDataReader dr = objCommand.ExecuteReader();
                if (dr.Read())
                {
                    txtFirstName.Text = dr[0].ToString();
                    txtLastName.Text = dr[1].ToString();
                    txtSNNITNo.Text = dr[2].ToString();
                }
                else
                {
                    MessageBox.Show($"No record found with employee id {txtEmployeeID.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}", "Selection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                objSqlConn.Close();
            }
        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }
        // SEARCH: 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder searchStatement = new StringBuilder();
            try
            {
                if (txtEmployeeID.Text.Length > 0)
                {
                    searchStatement.Append($"Convert( EmployeeID, 'System.String') like '%{txtEmployeeID.Text}%' ");
                }

                if (txtFirstName.Text.Length > 0)
                {
                    if (searchStatement.Length > 0)
                    {
                        searchStatement.Append(" and ");
                    }
                    searchStatement.Append($"Firstname like '%{txtFirstName.Text}%' ");
                }
                employeeBindingSource.Filter = searchStatement.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmCrystalReport crystalreport = new FrmCrystalReport();
            crystalreport.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblDOB_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxStaffWelfare_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSNNITNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        

        private void grbMaritalStatus_Enter(object sender, EventArgs e)
        {

        }

        private void grbEmployeeInformation_Enter(object sender, EventArgs e)
        {

        }
    }
}