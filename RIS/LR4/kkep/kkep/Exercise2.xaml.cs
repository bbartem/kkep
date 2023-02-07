using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace kkep
{
    /// <summary>
    /// Логика взаимодействия для Exercise2.xaml
    /// </summary>
    public partial class Exercise2 : Page
    {
        public Exercise2()
        {
            InitializeComponent();
            manager.mainFrame = mainFrame;
            mainFrame.Navigate(new Authorization());
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            manager.mainFrame.GoBack();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
        }

        private void mainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (manager.mainFrame.CanGoBack)
            {
                //this.ResizeMode = ResizeMode.CanResize;
                btnBackExercise2.Visibility = Visibility.Visible;
            }
            else
            {
                //this.ResizeMode = ResizeMode.NoResize;
                btnBackExercise2.Visibility = Visibility.Collapsed;
            }

            if (manager.user == null)
            {
                userInfo.Visibility = Visibility.Collapsed;
            }
            else
            {
                userInfo.Text = "Пользователь: " + manager.user.Name + " " + manager.user.Surname;
                userInfo.Visibility = Visibility.Visible;
            }
        }

        private void btnExitExercise2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBackExercise2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
