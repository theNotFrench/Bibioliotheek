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
    public partial class Form6 : Form
    {
        string connectionString = "server=localhost;database=filmproject;uid=root;pwd='';";
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            loadLendingData();
        }

        public void loadLendingData()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string qry = "SELECT tblgames.* FROM tblgames JOIN tbllijnuitlenen ON tblgames.gameID = tbllijnuitlenen.gameID JOIN tbluitlenen ON tbllijnuitlenen.uitleenid = tbluitlenen.uitleenid WHERE tbluitlenen.klantid = ?";
                MySqlCommand command = new MySqlCommand(qry, connection);
                command.Parameters.AddWithValue("", frmMain.klantidstored);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("You have not borrowed any games.");
                }
                else
                {
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
            finally { connection.Close(); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                int gameId = Convert.ToInt32(row.Cells["gameID"].Value);

                DialogResult dialogResult = MessageBox.Show("Do you want to return this game?", "Return Game", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string connectionString = "server=localhost;database=filmproject;uid=root;pwd='';";
                    MySqlConnection connection = new MySqlConnection(connectionString);

                    try
                    {
                        connection.Open();


                        string fetchQuery = "SELECT uitleenid FROM tbllijnuitlenen WHERE gameID = ?";
                        MySqlCommand fetchCommand = new MySqlCommand(fetchQuery, connection);
                        fetchCommand.Parameters.AddWithValue("", gameId);
                        int uitleenid = Convert.ToInt32(fetchCommand.ExecuteScalar());

                        string qry1 = "DELETE FROM tbllijnuitlenen WHERE gameID = ?";
                        MySqlCommand command1 = new MySqlCommand(qry1, connection);
                        command1.Parameters.AddWithValue("", gameId);
                        command1.ExecuteNonQuery();

                        string qry2 = "DELETE FROM tbluitlenen WHERE uitleenid = ?";
                        MySqlCommand command2 = new MySqlCommand(qry2, connection);
                        command2.Parameters.AddWithValue("", uitleenid);
                        command2.ExecuteNonQuery();

                        MessageBox.Show("Game returned successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                    loadLendingData();
                }
            }
        }

        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain mainForm = new frmMain();
            mainForm.Show();
            this.Hide();
        }
    }
}
