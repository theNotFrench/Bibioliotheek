﻿using MySql.Data.MySqlClient;
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
                    string qry = "INSERT INTO tblklant (klantnaam, gebruikernaam, wachtwoord) VALUES (?,?,?)";
                    MySqlCommand command = new MySqlCommand(qry, connection);
                    command.Parameters.AddWithValue("", username);
                    command.Parameters.AddWithValue("", password);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Succesfully logged in");
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
