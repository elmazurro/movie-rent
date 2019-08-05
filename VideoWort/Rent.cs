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
    public partial class Rent : Form
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private decimal Cost;
        private string Date;
        private int IdRecord;
        Client client = new Client();
        Film film = new Film();

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            client.Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //client.FirstName = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            //client.SurrName = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            //client.Pesel = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void Rentbutton_Click(object sender, EventArgs e)
        {

            Date = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            server = "127.0.0.1";//adres localhost 
            database = "filmy";
            uid = "root";
            password = "";
            string constring;
            constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            if (client.Id == 0)
            {
                MessageBox.Show("Błąd nie wybrałeś klienta", "Błąd wypożyczania filmu");
            }
            else if (IdRecord == 0)
            {
                MessageBox.Show("Błąd nie wybrałeś filmu", "Błąd wypożyczania filmu");
            }
            else if(Convert.ToDateTime(Date) <= DateTime.Today)
            {
                MessageBox.Show("Musisz wypożyczyć przynajmniej na dzień", "Błąd wypożyczania filmu");
            }
            else
            {
                using (var connection = new MySqlConnection(constring))
                {
                    connection.Open();
                    using (var cmdDataBase = connection.CreateCommand())
                    {


                        cmdDataBase.CommandText = "INSERT INTO platnosci(Naleznosc, Klient_Id, Plyta_Id) SELECT kategoria.Cena, klient.Id ,plyta.Id FROM  kategoria, klient, plyta WHERE kategoria.Cena = @Cost AND klient.Id = @IdClient AND plyta.Id = @IdRecord;" +
                            "UPDATE platnosci SET Data_Od = @Od , Data_do = @Do, Kwota_zaplacona = @Cost WHERE Plyta_Id = @IdRecord;";


                        cmdDataBase.Parameters.AddWithValue("@Cost", Cost);
                        cmdDataBase.Parameters.AddWithValue("@IdClient", client.Id);
                        cmdDataBase.Parameters.AddWithValue("@IdRecord", IdRecord);
                        cmdDataBase.Parameters.AddWithValue("@Od", DateTime.Today.ToString("yyyy-MM-dd"));
                        cmdDataBase.Parameters.AddWithValue("@Do", Date);

                        cmdDataBase.ExecuteNonQuery();

                        Close();

                    }
                }
            }
        }


        public Rent()
        {
            InitializeComponent();
            DisplayDataClient();
            DisplayDataMovie();
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

        void DisplayDataMovie()
        {
            server = "127.0.0.1";//adres localhost 
            database = "filmy";
            uid = "root";
            password = "";
            string constring;
            constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(constring);
           
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT F.Id AS Film_Id, P.Id AS Plyta_Id, F.Tytul,F.Rezyser,  k.Rodzaj, k.Cena from film F INNER JOIN plyta P ON  F.Id = P.Film_Id INNER JOIN kategoria K ON F.Kategoria_filmu = k.Id WHERE p.Id NOT IN (SELECT Plyta_Id FROM platnosci) OR p.Id IN(SELECT Plyta_Id FROM platnosci WHERE ( Data_do <= '"+DateTime.Today.ToString("yyyy-MM-dd")+ "' AND Oddanie IS NOT NULL) OR Oddanie IS NOT NULL ) ", conDataBase);
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

        private void dataGridView2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Przeniesione do CELLCLICK

            //film.Id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            //IdRecord = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
            //Cost = Convert.ToDecimal(dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString());
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1) client.Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                film.Id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                IdRecord = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString());
                Cost = Convert.ToDecimal(dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
        }
    }
}
    

