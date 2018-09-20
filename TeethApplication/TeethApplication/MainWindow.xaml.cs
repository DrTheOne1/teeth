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
            Page patientPage = new PatientPage();
            this.mainFrame.Navigate(patientPage);
        }

        private void ButtonShowPatients_Click(object sender, RoutedEventArgs e)
        {
            Page patientPage = new PatientPage();
            this.mainFrame.Navigate(patientPage);
        }

        private void ButtonBookTime_Click(object sender, RoutedEventArgs e)
        {
            Booking booking = new Booking();
            booking.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Collapsed;

        }
    }
}