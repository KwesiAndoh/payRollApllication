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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private Users objUser;

        // For validating the entries of the form Register
        private bool isControlDataValid()
        {
            const int minPasswordCharacter = 8;

            // UserName validation
            if (txtUserName.Text.Length == 0)
            {
                MessageBox.Show("Please enter user name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUserName.Focus();
                txtUserName.BackColor = Color.Beige;
                return false;
            }
            else
            {
                txtUserName.BackColor = Color.Bisque;
            }


            // Password Requirement
            //1. The password must be a minimum of 8 characters
            //2. The password must contain at least one upper character
            //3. The password must contain at least one lower character
            //4. The password must contain at least one numeric digit
            if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Password", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPassword.Focus();
                txtPassword.BackColor = Color.Beige;
                return false;
            }
            else if (txtPassword.Text.Length < minPasswordCharacter || CheckUpperCase(txtPassword.Text) < 1 || CheckLowerCase(txtPassword.Text) < 1 ||CheckNumeric(txtPassword.Text) < 1)
            {
                MessageBox.Show("Please, Enter  a valid Password. \n\n Hint:\nThe password must be a minimum of 8 characters \n The password must contain at least one upper character \n The password must contain at least one lower character \nThe password must contain at least one numeric digit ", "Data Entery Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                txtPassword.Focus();
                txtPassword.BackColor = Color.Beige;

                return false;
            }           
            else
            {
                txtPassword.BackColor = Color.Bisque;
            }


            // validating confirm password
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password does not match, please try again", "Data Entery Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtConfirmPassword.Focus();
                txtConfirmPassword.BackColor = Color.Beige;
                txtPassword.BackColor = Color.Beige;
                return false;
            }
            else
            {
                txtConfirmPassword.BackColor = Color.Bisque;
            }

            //role validation
            if (txtRole.Text.Length == 0)
            {
                MessageBox.Show("Please,Enter User Role", "Data Entery Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtRole.Focus();
                txtRole.BackColor = Color.Beige;
                return false;
            }
            else
            {
                txtRole.BackColor = Color.Bisque;
            }

            return true;
        }

        private int CheckNumeric(string strPassword)
        {
            int numberOfDigit = 0;
            foreach (char ch in strPassword)
                if (char.IsNumber(ch))
                {
                    numberOfDigit++;
                }
            return numberOfDigit;
        }

        private int CheckLowerCase(string strPassword)
        {
            int numberOfLower = 0;
            foreach(char ch in strPassword)
                if (char.IsLower(ch))
                {
                    numberOfLower++;
                }
            return numberOfLower;
        }

        private int CheckUpperCase(string strPassword)
        {
            int numberOfUpper = 0;
            foreach(char ch in strPassword)
                if (char.IsUpper(ch))
                {
                    numberOfUpper++;
                } 
            return numberOfUpper;
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payRollSystemDBDataSet6.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.payRollSystemDBDataSet6.Users);
            // TODO: This line of code loads data into the 'payRollSystemDBDataSet1.Users' table. You can move, or remove it, as needed.
            //    this.usersTableAdapter.Fill(this.payRollSystemDBDataSet1.Users);

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        // CLOSE: Closes the registration form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


        void ClearControl()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtRole.Text = string.Empty;
            txtRoleDescription.Text = string.Empty;
        }

        // Clears the input
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        void checkData()
        {
            objUser = new Users();
            objUser.UserName = txtUserName.Text;
            objUser.Password = txtPassword.Text;
            objUser.Role = txtRole.Text;
            objUser.RoleDescription = txtRoleDescription.Text;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (isControlDataValid())
                {
                    checkData();
                    objUser.AddUser();
                    MessageBox.Show(" User Register", "Add user succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
  //                  this.usersTableAdapter.Fill(this.payRollSystemDBDataSet1.Users);
                    ClearControl();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration failed {ex.Message}");
            }            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtRole.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtRoleDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            checkData();
            objUser.UpdateUser();
            MessageBox.Show(" User Updated", "User Updated succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
     //       this.usersTableAdapter.Fill(this.payRollSystemDBDataSet1.Users);
            ClearControl();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objUser.deleteUser();
            MessageBox.Show(" User Deleted", "User Delete succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
   //         this.usersTableAdapter.Fill(this.payRollSystemDBDataSet1.Users);
        }

        private void groupBoxRegister_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxRegisteredUsers_Enter(object sender, EventArgs e)
        {

        }
    }
}
