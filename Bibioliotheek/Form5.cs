using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibioliotheek
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMain mainForm = new frmMain();
            string connectionString = "server=localhost;database=filmproject;uid=root;pwd='';";
            MySqlConnection connection = new MySqlConnection(connectionString);


            try
            {
                string username = Convert.ToString(txtusername.Text);
                string password = Convert.ToString(txtwachtwoord.Text);

                connection.Open();

                if (username.Equals(""))
                {
                    MessageBox.Show("Give in a username");
                    txtusername.Focus();
                }
                else if (password.Equals(""))
                {
                    MessageBox.Show("Give in a password");
                    txtwachtwoord.Focus();
                }
                else
                {
                    string qry = "SELECT klantid FROM tblklant WHERE gebruikernaam = ? AND wachtwoord = ?";
                    MySqlCommand command = new MySqlCommand(qry, connection);
                    command.Parameters.AddWithValue("", username);
                    command.Parameters.AddWithValue("", password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            frmMain.klantidstored = reader.GetInt32(0);
                            MessageBox.Show("Successfully logged in");
                            mainForm.isLoggedIn = true;
                            mainForm.Show();
                            this.Hide();
                        }
                        else 
                        {
                            MessageBox.Show("Invalid username or password");
                        }
                    }
                        

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
