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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public string AccountHolder;
        public Menu(string user)
        {
            InitializeComponent();
            AccountHolder = user;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Explore OpenExplore = new Explore(AccountHolder);
            OpenExplore.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Favorites OpenFavorites = new Favorites(AccountHolder);
            OpenFavorites.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Saved OpenSaved = new Saved(AccountHolder);
            OpenSaved.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            LogIn OpenLogIn = new LogIn();
            OpenLogIn.Show();
            this.Close();
        }
    }
}
