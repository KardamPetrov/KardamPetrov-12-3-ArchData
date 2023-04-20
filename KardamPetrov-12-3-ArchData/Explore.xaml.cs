using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KardamPetrov_12_3_ArchData
{
    /// <summary>
    /// Interaction logic for Explore.xaml
    /// </summary>
    public partial class Explore : Window
    {
        public SqlConnection sqlCon = new SqlConnection(@"Data Source=THESTRIXSCAROFK; Initial Catalog=ArchData; Integrated Security=True");

        public Explore()
        {
            InitializeComponent();
        }

        private void Fav_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon.Open();
                string query = "INSERT INTO Favorites ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sav_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon.Open();
                string query1 = "INSERT INTO Saved ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                SqlCommand cmd = new SqlCommand(query1, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fav1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon.Open();
                string query = "INSERT INTO Favorites ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sav1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon.Open();
                string query1 = "INSERT INTO Saved ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                SqlCommand cmd = new SqlCommand(query1, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fav2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon.Open();
                string query = "INSERT INTO Favorites ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sav2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon.Open();
                string query1 = "INSERT INTO Saved ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                SqlCommand cmd = new SqlCommand(query1, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fav3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon.Open();
                string query = "INSERT INTO Favorites ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sav3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon.Open();
                string query1 = "INSERT INTO Saved ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                SqlCommand cmd = new SqlCommand(query1, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fav7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon.Open();
                string query = "INSERT INTO Favorites ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sav7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon.Open();
                string query1 = "INSERT INTO Saved ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                SqlCommand cmd = new SqlCommand(query1, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sav6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon.Open();
                string query = "INSERT INTO Favorites ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fav6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon.Open();
                string query1 = "INSERT INTO Saved ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                SqlCommand cmd = new SqlCommand(query1, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sav5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon.Open();
                string query = "INSERT INTO Favorites ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fav5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon.Open();
                string query1 = "INSERT INTO Saved ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                SqlCommand cmd = new SqlCommand(query1, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fav4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon.Open();
                string query = "INSERT INTO Favorites ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sav4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlCon.Open();
                string query1 = "INSERT INTO Saved ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                SqlCommand cmd = new SqlCommand(query1, sqlCon);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Favorites OpenFav = new Favorites();
            OpenFav.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Saved OpenSav = new Saved();
            OpenSav.Show();
            this.Close();
        }
    }
}
