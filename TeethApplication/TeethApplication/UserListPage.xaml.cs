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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TeethApplication
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class UserListPage : Page
    {
        public UserListPage()
        {
            InitializeComponent();

            List<User> users = new List<User>();
            users.Add(new User("Arnold", "Agustus", "Admin", "legit.mail@NoScam.se", "*****", 1));
            users.Add(new User("Billy", "Bob", "User", "bill.bob@fakeMail.com", "*****", 2));

            UsersList.ItemsSource = users;
        }



        private void PatientList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OverTooth.mainWindow.mainFrame.Navigate(new Journal());
        }

        private void ButtonCreateNewUser_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}


