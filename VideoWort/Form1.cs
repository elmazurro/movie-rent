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
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;


        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }

        public void DisplayData()
        {
            server = "127.0.0.1";//adres localhost 
            database = "filmy";
            uid = "root";
            password = "";
            string constring;
            constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(constring);

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select F.Tytul,F.Rezyser, ( CASE WHEN F.Kategoria_filmu = '1' THEN 'Nowosc' WHEN F.Kategoria_filmu = '2' THEN 'Klasyk' ELSE 'Oldschool' END) AS Kategoria from film F INNER JOIN plyta P ON  F.Id = P.Film_Id ;", conDataBase);
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

            private void dodajFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";//adres localhost 
            database = "filmy";
            uid = "root";
            password = "";
            string constring;
            constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(constring);

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select Imie, Nazwisko, Pesel, Adres, Telefon  FROM klient", conDataBase);
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


        private void listaFilmówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";//adres localhost 
            database = "filmy";
            uid = "root";
            password = "";
            string constring;
            constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(constring);

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select F.Tytul,F.Rezyser, ( CASE WHEN F.Kategoria_filmu = '1' THEN 'Nowosc' WHEN F.Kategoria_filmu = '2' THEN 'Klasyk' ELSE 'Oldschool' END) AS Kategoria from film F INNER JOIN plyta P ON  F.Id = P.Film_Id ;", conDataBase);
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

        private void dodajKlientaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddClient ad = new AddClient();
            ad.ShowDialog();
        }

        private void edytujKlientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditClient ed = new EditClient();
            ed.ShowDialog();
        }

        private void usuńKlientaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dodajFilmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddFilm fm = new AddFilm();
            fm.ShowDialog();
        }

        private void listaWypożyczeńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";//adres localhost 
            database = "filmy";
            uid = "root";
            password = "";
            string constring;
            constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(constring);

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select k.Imie, k.Nazwisko, F.Tytul,  pl.Data_od, pl.Data_do, pl.Oddanie, pl.Naleznosc, pl.Kwota_zaplacona FROM film F INNER JOIN plyta P ON  F.Id = P.Film_Id INNER JOIN platnosci pl ON P.Id = pl.Plyta_Id INNER JOIN klient k ON pl.Klient_Id = k.Id;", conDataBase);
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

        private void wypożyczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rent rn = new Rent();
            rn.ShowDialog();
        }

        

        private void oddanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return re = new Return();
            re.Show();
        }
    }
}
