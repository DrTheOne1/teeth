﻿using System;
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

namespace TeethApplication
{
    /// <summary>
    /// Interaction logic for Administration.xaml
    /// </summary>
    public partial class Administration : Window
    {
        public Administration()
        {
            InitializeComponent();
            //Page adminPage = new AdminPage();
            //this.mainFrame.Navigate(adminPage);

            Page userlistPage = new UserListPage();
            this.mainFrame.Navigate(userlistPage);
        }

        private void ButtonCreateNewUser_Click(object sender, RoutedEventArgs e)

        {

            Page newUserPage = new CreateUserPage();
            this.mainFrame.Navigate(newUserPage);
     
         
        }
        private void ButtonUserList_Click(object sender, RoutedEventArgs e)

        {

            Page userListPage = new UserListPage();
            this.mainFrame.Navigate(userListPage);


        }

        private void ButtonLogout_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();

            login.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Collapsed;
        }
    }
}
