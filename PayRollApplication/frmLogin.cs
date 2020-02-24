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
    public partial class frmLoginRole : Form
    {
        public frmLoginRole()
        {
            InitializeComponent();
        }

        // initializing a user class
        private Users currentuser = new Users();

        //Accepting info from the Login
        void UserData()
        {
            currentuser.UserName = txtUsername.Text;
            currentuser.Password = txtPassword.Text;
            currentuser.Role = cmbRole.Text;
        }

        private void frmLoginRole_Load(object sender, EventArgs e)
        {
            selectRole();
        }

        //private int loginCount = 0;
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            UserData();
            try
            {
                if (currentuser.AuthUser())
                {
                    // load the MDI form
                    FormPayrollMDI frmMDI = new FormPayrollMDI();
                   
                    //hiding the login form
                    this.Hide();

                    //display the MDI form
                    frmMDI.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User Name Or Password, Please try again", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                // Add 3 login attempts 
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        void selectRole()
        {
            //1 SQL Connection
            // connection string: gotten from system. configuration
            string conn = ConfigurationManager.ConnectionStrings["PayRollApplication"].ConnectionString;
            // instance of sql connection
            SqlConnection objConn = new SqlConnection(conn);

            SqlCommand roleCmd = new SqlCommand("spSelectRoles", objConn);
            roleCmd.CommandType = CommandType.StoredProcedure;
        
            try
            {
                objConn.Open();
                SqlDataReader dr = roleCmd.ExecuteReader();

                while (dr.Read())
                {
                    cmbRole.Items.Add(dr[0]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
            finally
            {
                objConn.Close();
            }
        }
        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister register = new FrmRegister();
            register.Show();
        }
    }
}
