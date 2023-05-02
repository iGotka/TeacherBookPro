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
using TeacherBook.Controllers;
using TeacherBook.Models;

namespace TeacherBook.Windowed
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                User result=UserController.Auth(LoginBlock.Text, PasswordBlock.Name);
                if (result != null)
                {
                    NavigationService.Navigate(new PrepodPage());
                }
               
            }
            catch (Exception)
            {

                throw;
            }
              
            
            
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }

        private void LoginBlock_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
