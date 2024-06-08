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
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex]; //krijgt de rij waarop geklikt is
                int gameID = Convert.ToInt32(row.Cells["gameID"].Value); //krijgt de gameID van de rij
                DialogResult dialogResult = MessageBox.Show("do you want to borrow this game?", "Borrow Game", MessageBoxButtons.YesNo); //vraagt of de gebruiker de game wilt lenen
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    try
                    {
                        connection.Open();
                        string updateQry = "UPDATE tblLenen SET uitlenen = ? WHERE gameID = ?";
                        MySqlCommand updateCommand = new MySqlCommand(updateQry, connection);
                        updateCommand.Parameters.AddWithValue("", true);
                        updateCommand.Parameters.AddWithValue("", gameID);
                        updateCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                    
                    loadData();
                }
            }
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
                MessageBox.Show("error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=filmproject;uid=root;pwd='';";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string gameId = Convert.ToString(Interaction.InputBox("Enter the ID of the game"));

                string fetchQuery = "SELECT * FROM tblgames WHERE gameID = ?";
                MySqlCommand fetchCommand = new MySqlCommand(fetchQuery, connection);
                fetchCommand.Parameters.AddWithValue("", gameId);
                MySqlDataReader reader = fetchCommand.ExecuteReader();

                if (reader.Read())
                {

                    string newTitle = Convert.ToString(Interaction.InputBox("Enter the new title of the game", "Update Game", reader["gamenaam"].ToString()));
                    string newProducer = Convert.ToString(Interaction.InputBox("enter a new producer of the game", "Update Game", reader["producer"].ToString()));
                    string newJaarString;
                    int newJaar;
                    do
                    {
                        newJaarString = Interaction.InputBox("Enter the new year of the game", "Update Game", reader["uitgavejaar"].ToString());
                        if (!int.TryParse(newJaarString, out newJaar))
                        {
                            MessageBox.Show("Invalid year entered. Please enter a valid number.");
                        }
                    } while (!int.TryParse(newJaarString, out newJaar));

                    reader.Close();

                    string updateQuery = "UPDATE tblgames SET gamenaam = ?, producer = ? , uitgavejaar= ?  WHERE gameID = ?";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("", newTitle);
                    updateCommand.Parameters.AddWithValue("", newProducer);
                    updateCommand.Parameters.AddWithValue("", newJaar);
                    updateCommand.Parameters.AddWithValue("", gameId);
                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show("Game details updated successfuly");
                }
                else
                {
                    MessageBox.Show("No game found with the entered ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            loadData();
        }

        public void loadData() 
        {

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string qry = "SELECT tblgames.* FROM tblgames";
                MySqlCommand command = new MySqlCommand(qry, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
            finally { connection.Close(); }
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
