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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click_1(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=filmproject;uid=root;pwd='';";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {

                connection.Open();
                string titel = Convert.ToString(txttitel.Text);
                string jaarString;
                int jaar;
                do
                {
                    jaarString = txtjaar.Text;
                    if (!int.TryParse(jaarString, out jaar))
                    {
                        MessageBox.Show("Invalid year entered.");
                    }
                } while (!int.TryParse(jaarString, out jaar));
                string qry = "INSERT INTO tblfilms (titel,jaar,aantalDagenOntlening) VALUES (?,?)";
                MySqlCommand command = new MySqlCommand(qry, connection);
                command.Parameters.AddWithValue("", titel);
                command.Parameters.AddWithValue("", jaar);
                command.ExecuteNonQuery();
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
