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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=filmproject;uid=root;pwd='';";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {

                connection.Open();
                string titel = Convert.ToString(txttitel.Text);
                int jaar = Convert.ToInt16(txtjaar.Text);
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
