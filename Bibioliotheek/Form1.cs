using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Bibioliotheek
{

    public partial class frmMain : Form
    {
        public string naam;
        string connectionString = "server=localhost;database=filmproject;uid=root;pwd='';";
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            MySqlConnection connection = new MySqlConnection(connectionString);

            try 
            {
                connection.Open();
                string qry = "Select * from tblfilms";
                MySqlCommand command = new MySqlCommand(qry, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("er is een fout opgetreden: " + ex.Message);
            }
            finally { connection.Close(); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            Form2 frmtoevoegen_instantie = new Form2();
            frmtoevoegen_instantie.Show();
            this.Hide();
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string zoekqry = Convert.ToString(Interaction.InputBox("geef in de naam van een film"));
                string query = "SELECT * FROM tblfilms where titel like ?";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("", "%" +zoekqry + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate frmUpdate_insantie = new frmUpdate();
            frmUpdate_insantie.Show();
            this.Hide();
        }
    }
}
