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

namespace LR5_Triggers
{
    public partial class MainWindow : Window
    {
        Person src = new Person { Name = "Ali", Age = 27 };
        List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            people.Add(src);
            people.Add(new Person { Name = "Mike", Age = 62 });
            people.Add(new Person { Name = "Brian", Age = 12 });
            this.DataContext = people;
        }
        private void Button_Click (object sender, RoutedEventArgs e)
        {
            string message = src.Name + " is " + src.Age;
            MessageBox.Show(message);
        }
    }
}
