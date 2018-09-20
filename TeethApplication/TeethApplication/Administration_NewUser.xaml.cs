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

namespace TeethApplication
{
    /// <summary>
    /// Interaction logic for Administration_NewUser.xaml
    /// </summary>
    public partial class Administration_NewUser : Window
    {
        public Administration_NewUser()
        {
            InitializeComponent();
        }

        private void ButtonNewUser_Click(object sender, RoutedEventArgs e)
        {
            Administration administration = new Administration();

            administration.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Collapsed;
        }

        private void ButtonAbort_Click(object sender, RoutedEventArgs e)
        {
            Administration administration = new Administration();

            administration.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Collapsed;
        }
    }
}
