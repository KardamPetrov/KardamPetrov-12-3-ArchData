﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
    /// Interaction logic for Favorites.xaml
    /// </summary>

    public partial class Favorites : Window
    {
         public string AccountHolder;
         public Favorites(string user)
        {
            InitializeComponent();
            AccountHolder=user;
            neshto();
        }


        void neshto ()
        {
            string dbsCon = @"Data Source=THESTRIXSCAROFK; Initial Catalog=ArchData; Integrated Security=True";
            SqlConnection sqlCon_ = new SqlConnection(dbsCon);

            try
            {
                sqlCon_.Open();
                string query = "Select * from Favorites";
                SqlCommand cmd = new SqlCommand(query, sqlCon_);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                IME.ItemsSource = dt.DefaultView;
                adapter.Update(dt);

                MessageBox.Show("Successful loading");
                sqlCon_.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu OpenMenu = new Menu(AccountHolder);
            OpenMenu.Show();
            this.Close();
        }
    }
}
