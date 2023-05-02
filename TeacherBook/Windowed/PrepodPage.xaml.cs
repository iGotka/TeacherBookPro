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

namespace TeacherBook.Windowed
{
    /// <summary>
    /// Логика взаимодействия для PrepodPage.xaml
    /// </summary>
    public partial class PrepodPage : Page
    {
        public PrepodPage()
        {
            InitializeComponent();
        }


        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddStudentPage());
        }

        private void AddEvalutionButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEvolutionPage());
        }

        private void StudentListButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StudentListPage());
        }

        private void RegEvalutinButton_Click(object sender, RoutedEventArgs e)
        {
            //Button btnEdit = sender as Button;
            //AddEvolutionPage activeElement = btnEdit.DataContext as AddEvolutionPage;
            //var win = new AddEvolutionPage(activeElement);
            //win.ShowDialog();
        }

        private void DeleteStudentButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DeleteStudentPage());
        }
    }
}
