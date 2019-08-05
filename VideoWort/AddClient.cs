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

    public partial class AddClient : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        Client cl = new Client();
        public AddClient()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";//adres localhost 
            database = "filmy";
            uid = "root";
            password = "";
            string constring;
            constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            //connection = new MySqlConnection(constring);

                if (String.IsNullOrEmpty(FirstNametextbox.Text) || String.IsNullOrEmpty(SurrNametextbox.Text) || String.IsNullOrEmpty(Addresbox.Text) || String.IsNullOrEmpty(Phonebox.Text))
                {
                    MessageBox.Show("Błędne lub niekompletne informacje", "Błąd dodawania filmu");
                }
                else if (Peselbox.Text.Length != 11)
                {
                    MessageBox.Show("Podany PESEL ma błędną wartość", "Błędny PESEL");
                }
                else
                {
                    cl.FirstName = FirstNametextbox.Text;
                    cl.SurrName = SurrNametextbox.Text;
                    cl.Pesel = Peselbox.Text;
                    cl.Addres = Addresbox.Text;
                    cl.Phone = Phonebox.Text;



                    using (var connection = new MySqlConnection(constring))
                    {
                        connection.Open();
                        using (var cmdDataBase = connection.CreateCommand())
                        {
                            cmdDataBase.CommandText = "INSERT INTO klient(Imie, Nazwisko, Pesel, Adres, Telefon) VALUES (@Imie, @Nazwisko, @Pesel, @Adres, @Telefon)";
                            cmdDataBase.Parameters.Add(new MySqlParameter("@Imie", cl.FirstName));
                            cmdDataBase.Parameters.Add(new MySqlParameter("@Nazwisko", cl.SurrName));
                            cmdDataBase.Parameters.Add(new MySqlParameter("@Pesel", cl.Pesel));
                            cmdDataBase.Parameters.Add(new MySqlParameter("@Adres", cl.Addres));
                            cmdDataBase.Parameters.Add(new MySqlParameter("@Telefon", cl.Phone));
                            cmdDataBase.ExecuteNonQuery();

                        }
                    }
                    Close();
                }
            


            //try
            //{
            //    MySqlDataAdapter sda = new MySqlDataAdapter();
            //    sda.SelectCommand = cmdDataBase;
            //    DataTable dbdataset = new DataTable();
            //    sda.Fill(dbdataset);
            //    BindingSource bSource = new BindingSource();

            //    bSource.DataSource = dbdataset;
            //    dataGridView1.DataSource = bSource;
            //    sda.Update(dbdataset);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        ///ZABEZPIECZENIA
        private void Peselbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void FirstNametextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void SurrNametextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 45)
            {
                e.Handled = true;
            }
        }

        private void Phonebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 43)
            {
                e.Handled = true;
            }
        }
        



        
    }
}
