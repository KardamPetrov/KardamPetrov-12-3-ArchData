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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SingUp : Window
    {
        public SingUp()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow OpenMainWindow = new MainWindow();
            OpenMainWindow.Show();
            this.Close();
        }
        private void Submit_1_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password.Length < 10 || PasswordBox.Password.Length > 10)
            {
                MessageBox.Show("Try again");
            }
            else if (txtUsername.Text.Equals(""))
            {
                MessageBox.Show("Field cannot be empty!");
            }
            else if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email should have an '@'!");
            }
            else if (!(PasswordBox.Password == RePasswordBox.Password))
            {
                MessageBox.Show("The passwords don't match!Try again.");
            }
            else
            {
                SqlConnection sqlCon = new SqlConnection(@"Data Source=THESTRIXSCAROFK; Initial Catalog=ArchData; Integrated Security=True");
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO SignUpTable ([Username],[Email],[password],[Repeat Password]) values ('" + this.txtEmail.Text + "','" + this.txtUsername.Text + "','" + this.PasswordBox.Password + "','" + this.RePasswordBox.Password + "') ";
                    SqlCommand cmd = new SqlCommand(query, sqlCon);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Saved Successfully!");

                    LogIn lg = new LogIn();
                    lg.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }

    }
}
