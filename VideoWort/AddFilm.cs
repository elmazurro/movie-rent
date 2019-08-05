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
    public partial class AddFilm : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        int n;

        Film fm = new Film();
        public AddFilm()
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

            if (String.IsNullOrEmpty(TitleBox.Text) || String.IsNullOrEmpty(DirectroBox.Text) || String.IsNullOrEmpty(YearBox.Text) || CategoryBox.SelectedIndex < 0 || PieceBox.SelectedIndex < 0) 
            {
                MessageBox.Show("Błędne lub niekompletne informacje", "Błąd dodawania filmu");
            }
            else
            {

                fm.Title = TitleBox.Text;
                fm.Director = DirectroBox.Text;
                fm.Year = Convert.ToInt32(YearBox.Text);
                fm.Category = CategoryBox.Text;
                if (fm.Category == "Nowosc")
                {
                    n = 1;
                }
                else if (fm.Category == "Klasyk")
                {
                    n = 2;
                }
                else n = 3;

                using (var connection = new MySqlConnection(constring))
                {

                        connection.Open();
                        using (var cmdDataBase = connection.CreateCommand())
                        {


                            //cmdDataBase.CommandText = "INSERT INTO plyta(Film_Id) SELECT ID FROM film F INNER JOIN plyta P ON F.Id = P.Film_Id";
                            cmdDataBase.CommandText = "INSERT INTO film(Tytul, Rezyser, Rok, Kategoria_filmu) VALUES (@Tytul, @Rezyser, @Rok, @Kategoria_filmu) ";
                            cmdDataBase.Parameters.Add(new MySqlParameter("@Tytul", fm.Title));
                            cmdDataBase.Parameters.Add(new MySqlParameter("@Rezyser", fm.Director));
                            cmdDataBase.Parameters.Add(new MySqlParameter("@Rok", fm.Year));
                            cmdDataBase.Parameters.Add(new MySqlParameter("@Kategoria_filmu", n));
                            cmdDataBase.ExecuteNonQuery();

                            for (int i = 0; i < PieceBox.SelectedIndex + 1; i++)
                            {
                                cmdDataBase.CommandText = "INSERT INTO plyta(Film_Id) SELECT Id From film WHERE film.Tytul = @Tytul";
                                cmdDataBase.ExecuteNonQuery();
                            }

                            


                        }
                        connection.Close();
                    MessageBox.Show("Dodałeś film", "Sukces");
                }

                Close();
            }

        }

        private void TitleBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void DirectroBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 45)
            {
                e.Handled = true;
            }
        }

        private void YearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }





    }
}
