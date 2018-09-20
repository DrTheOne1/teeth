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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = TextBoxUsername.Text.ToString();

            if (username  == "user")
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
            else if (username == "admin")
            {
                Administration administration = new Administration();
                administration.Show();
                this.Close();
            }
        }
    }
}