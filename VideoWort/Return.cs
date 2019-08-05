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

namespace VideoWort
{
    public partial class Return : Form
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int IdRecord;
        int ID;
        Client client = new Client();





        public Return()
        {
            InitializeComponent();
            DisplayDataClient();

        }


        void DisplayDataClient()
        {
            server = "127.0.0.1";//adres localhost 
            database = "filmy";
            uid = "root";
            password = "";
            string constring;
            constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(constring);

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select Id, Imie, Nazwisko, Pesel from klient ;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ReturnClick(object sender, EventArgs e)
        {
            server = "127.0.0.1";//adres localhost 
            database = "filmy";
            uid = "root";
            password = "";
            string constring;
            constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            using (var connection = new MySqlConnection(constring))
            {
                connection.Open();
                using (var cmdDataBase = connection.CreateCommand())
                {


                    cmdDataBase.CommandText = "UPDATE platnosci SET Oddanie = @Today WHERE Plyta_Id = @IdRecord";
                    cmdDataBase.Parameters.AddWithValue("@Today", DateTime.Today.ToString("yyyy-MM-dd"));
                    cmdDataBase.Parameters.AddWithValue("@IdRecord", IdRecord);
                    // cmdDataBase.Parameters.AddWithValue("@ClientId", client.Id);

                    cmdDataBase.ExecuteNonQuery();
                    MessageBox.Show("Płyta została zwrócona", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Close();

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                client.Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                client.FirstName = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                client.SurrName = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                client.Pesel = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();


                server = "127.0.0.1";//adres localhost 
                database = "filmy";
                uid = "root";
                password = "";
                string constring;
                constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                using (var connection = new MySqlConnection(constring))
                {
                    connection.Open();
                    using (var cmdDataBase = connection.CreateCommand())
                    {


                        cmdDataBase.CommandText = "SELECT * FROM platnosci WHERE Klient_Id = @idClient AND Oddanie IS NULL";

                        cmdDataBase.Parameters.AddWithValue("@idClient", client.Id);

                        cmdDataBase.ExecuteNonQuery();
                        try
                        {
                            MySqlDataAdapter sda = new MySqlDataAdapter();
                            sda.SelectCommand = cmdDataBase;
                            DataTable dbdataset = new DataTable();
                            sda.Fill(dbdataset);
                            BindingSource bSource = new BindingSource();

                            bSource.DataSource = dbdataset;
                            dataGridView2.DataSource = bSource;
                            sda.Update(dbdataset);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                dataGridView2.DataSource = null;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            { 
                IdRecord = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());
                ID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());
                server = "127.0.0.1";//adres localhost 
                database = "filmy";
                uid = "root";
                password = "";
                string constring;
                constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                using (var connection = new MySqlConnection(constring))
                {
                    connection.Open();
                    using (var cmdDataBase = connection.CreateCommand())
                    {


                        cmdDataBase.CommandText = "SELECT IF( Data_do < '"+DateTime.Today.ToString("yyyy-MM-dd")+"',(Naleznosc + 10 - Kwota_zaplacona) , (Naleznosc - Kwota_zaplacona)) FROM platnosci WHERE Klient_Id = @idClient AND Plyta_Id = @IdRecord ";
                        cmdDataBase.Parameters.AddWithValue("@idClient", ID);
                        cmdDataBase.Parameters.AddWithValue("@IdRecord", IdRecord);
                        cmdDataBase.ExecuteNonQuery();
                        try
                        {

                            textBox1.Text = cmdDataBase.ExecuteScalar().ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        




        }
    }
}


   

