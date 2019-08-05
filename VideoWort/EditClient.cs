using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VideoWort
{
    public partial class EditClient : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        Client client = new Client();
        public EditClient()
        {
            InitializeComponent();
        }

        private void AcceptEdit_Click(object sender, EventArgs e)
        {
            server = "127.0.0.1";//adres localhost 
            database = "filmy";
            uid = "root";
            password = "";
            string constring;
            constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            if (String.IsNullOrEmpty(Peselbox.Text) || String.IsNullOrEmpty(FirstNametextbox.Text) || String.IsNullOrEmpty(SurrNametextbox.Text) || String.IsNullOrEmpty(Addresbox.Text) || String.IsNullOrEmpty(Phonebox.Text))
            {
                MessageBox.Show("Błędne lub niekompletne informacje", "Błąd dodawania filmu");
            }
            else
            {
                client.Pesel = Peselbox.Text;               
                client.FirstName= FirstNametextbox.Text;
                client.SurrName = SurrNametextbox.Text;
                client.Addres = Addresbox.Text;
                client.Phone = Phonebox.Text;


                using (var connection = new MySqlConnection(constring))
                {
                    connection.Open();
                    using (var cmdDataBase = connection.CreateCommand())
                    {
                        
                        {
                            cmdDataBase.CommandText = "UPDATE klient SET Imie = @_imie, Nazwisko = @_nazwisko, Adres = @_adres, Telefon = @_telefon WHERE Pesel = @_pesel";

                            cmdDataBase.Parameters.AddWithValue("@_imie", client.FirstName);
                            cmdDataBase.Parameters.AddWithValue("@_nazwisko", client.SurrName);
                            cmdDataBase.Parameters.AddWithValue("@_adres", client.Addres);
                            cmdDataBase.Parameters.AddWithValue("@_telefon", client.Phone);
                            cmdDataBase.Parameters.AddWithValue("@_pesel", client.Pesel);

                            cmdDataBase.ExecuteNonQuery();
                        }
                       

                    }
                }
                Close();
            }
        }


        // ZABEZPIECZENIA
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

        private void Addresbox_KeyPress(object sender, KeyPressEventArgs e)
        {

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
