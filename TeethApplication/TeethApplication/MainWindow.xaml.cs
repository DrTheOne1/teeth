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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainPage mainPage = new MainPage();
            this.mainFrame.Navigate(mainPage);
        }
        public MainWindow(string username)
        {
            InitializeComponent();
            if (username == "user")
            {
                MainPage mainPage = new MainPage();
                this.mainFrame.Navigate(mainPage);
            }
            else { }
        }

        private void ButtonShowPatients_Click(object sender, RoutedEventArgs e)
        {
            Page patientPage = new PatientPage();
            this.mainFrame.Navigate(patientPage);
        }

        private void ButtonBookTime_Click(object sender, RoutedEventArgs e)
        {
            Page bookingPage = new BookingPage();
            this.mainFrame.Navigate(bookingPage);

        }
        private void ButtonLogout_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        public void ChangePage(Page page)
        {
            this.mainFrame.Navigate(page);
        }
    }
}
