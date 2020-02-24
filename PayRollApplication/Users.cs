using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollApplication
{
    class Users
    {
        private string _username;
        private string _password;
        private string _role;
        private string _roleDescription;

        public Users()
        {
                
        }
        public Users(string username, string password, string role, string roleDescription)
        {
            this._username = username;
            this._password = password;
            this._role = role;
            this._roleDescription = roleDescription;
        }

        public string UserName
        {
            get { return _username; } set { _username = value; }
        }
        public string Password
        {
            get {return _password; } set { _password = value; }
        }
        public string Role
        {
            get {return _role; } set { _role = value; }
        }
        public string RoleDescription
        {
            get { return _roleDescription; } set { _roleDescription = value; }
        }


        // For Registring the user
        public void AddUser()
        { 
            //1 SQL Connection
            // connection string: gotten from system. configuration
            string conn = ConfigurationManager.ConnectionStrings["PayRollApplication"].ConnectionString;

            // instance of sql connection
            SqlConnection objConn = new SqlConnection(conn);

            //Sql Command 
            SqlCommand objCommand = new SqlCommand("spInsertCommand", objConn);
            objCommand.CommandType = CommandType.StoredProcedure;

            objCommand.Parameters.AddWithValue("@UserName", UserName);
            objCommand.Parameters.AddWithValue("@Password", Password);
            objCommand.Parameters.AddWithValue("@Role", Role);
            objCommand.Parameters.AddWithValue("@RoleDescription", RoleDescription);


            try
            {
                objConn.Open();
                // executing a query into the databasee
                objCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"User Failure {ex.Message}", "Delete Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                objConn.Close();
            }
        }

        public void UpdateUser()
        {
            //1 SQL Connection
            // connection string: gotten from system. configuration
            string conn = ConfigurationManager.ConnectionStrings["PayRollApplication"].ConnectionString;

            // instance of sql connection
            SqlConnection objConn = new SqlConnection(conn);

            //Sql Command 
            SqlCommand objCommand = new SqlCommand("spUpdate", objConn);
            objCommand.CommandType = CommandType.StoredProcedure;

            objCommand.Parameters.AddWithValue("@UserName", UserName);
            objCommand.Parameters.AddWithValue("@Password", Password);
            objCommand.Parameters.AddWithValue("@Role", Role);
            objCommand.Parameters.AddWithValue("@RoleDescription", RoleDescription);

            // when Doing Update You ExecuteScalar
            try
            {
                objConn.Open();
                // executing a query into the databasee
                objCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update Failure {ex.Message}", "Update Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                objConn.Close();
            }
        }

        

        // DELETE:
        public void deleteUser()
        { 
            string conn = ConfigurationManager.ConnectionStrings["PayRollApplication"].ConnectionString;

            // instance of sql connection
            SqlConnection objConn = new SqlConnection(conn);

            //Sql Command 
            SqlCommand objCommand = new SqlCommand("spDelete", objConn);
            objCommand.CommandType = CommandType.StoredProcedure;

            objCommand.Parameters.AddWithValue("@UserName", UserName);
           
            // When Doing Update You ExecuteScalar
            try
            {
                objConn.Open();
                // executing a query into the database 
                objCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Delete Failure {ex.Message}", "Delete Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                objConn.Close();
            }
        }
     

        // For Logining in the User
        public bool AuthUser()
        {
            bool isAuthenticate = false;

            //1 SQL Connection
            // connection string: gotten from system. configuration
            string conn = ConfigurationManager.ConnectionStrings["PayRollApplication"].ConnectionString;

            // instance of sql connection
            SqlConnection objConn = new SqlConnection(conn);

            //Sql Command 
            SqlCommand userCmd = new SqlCommand("spAuthentication", objConn);
            userCmd.CommandType = CommandType.StoredProcedure;

            userCmd.Parameters.AddWithValue("@UserName", UserName);
            userCmd.Parameters.AddWithValue("@Password", Password);
            userCmd.Parameters.AddWithValue("@Role", Role);

            try
            {
                objConn.Open();
                isAuthenticate = Convert .ToBoolean(userCmd.ExecuteScalar()); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                objConn.Close();
            }
            return isAuthenticate;
        }
    }
}
