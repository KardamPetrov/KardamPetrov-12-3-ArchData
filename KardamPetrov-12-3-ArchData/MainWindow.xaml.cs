using System;
using System.Collections.Generic;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click1(object sender, RoutedEventArgs e)
        {
            SingUp OpenSignUp = new SingUp();
            OpenSignUp.Show();
            this.Close();
        }
        private void Submit_Click2(object sender, RoutedEventArgs e)
        {
            LogIn OpenLogIn = new LogIn();
            OpenLogIn.Show();
            this.Close();
        }
    }
}
