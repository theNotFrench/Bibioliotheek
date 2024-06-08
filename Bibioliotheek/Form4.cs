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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=filmproject;uid=root;pwd='';";
            MySqlConnection connection = new MySqlConnection(connectionString);


            try
            {


                connection.Open();

                string voornaam = Convert.ToString(txtnaam.Text);
                string username = Convert.ToString(txtGebruikersnaam.Text);
                string wachtwoord = Convert.ToString(txtWachtwoord.Text);

                if (voornaam.Equals(""))
                {
                    MessageBox.Show("Give in a name");
                    txtnaam.Focus();
                }
                else if (username.Equals(""))
                {
                    MessageBox.Show("Give in a username");
                    txtGebruikersnaam.Focus();
                }
                else if (wachtwoord.Equals(""))
                {
                    MessageBox.Show("Give in a password.");
                    txtWachtwoord.Focus();
                }
                else
                {
                    string qry = "INSERT INTO tblklant (klantnaam,gebruikernaam,wachtwoord,) VALUES (?,?,?)";
                    MySqlCommand command = new MySqlCommand(qry, connection);
                    command.Parameters.AddWithValue("", voornaam);
                    command.Parameters.AddWithValue("", username);
                    command.Parameters.AddWithValue("", wachtwoord);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Succesfully created user");
                    frmMain mainForm = new frmMain();
                    mainForm.Show();
                    this.Hide();
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
