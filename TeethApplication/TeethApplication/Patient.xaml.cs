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
    /// Interaction logic for Patient.xaml
    /// </summary>
    public partial class Patient : Window
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string BirthDate { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }



        }

        public Patient()
        {
            InitializeComponent();


           List<Person> patient = new List<Person>();
            patient.Add(new Person() {
                FirstName = "Kyle",
                LastName = "Me",
                BirthDate = "881022-1100",
                Address = "St.2, Mölndal",
                PhoneNumber = "082-1928372"});

            patient.Add(new Person()
            {
                FirstName = "Lily",
                LastName = "Kent",
                BirthDate = "440122-1340",
                Address = "Pilgatan 2, Göteborg",
                PhoneNumber = "032-1235372"
            });

            PatientList.ItemsSource = patient;
            

           
     
        }

        private void ButtonReturnToMain_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            


        }

        private void PatientList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
