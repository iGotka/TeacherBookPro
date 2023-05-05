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
    /// Логика взаимодействия для StudentListPage.xaml
    /// </summary>
    public partial class StudentListPage : Page
    {
        public StudentListPage()
        {
            InitializeComponent();
            List<Student> arrStudent = StudentController.GetStudent();
            List<Group> arrGroup = GroupController.GetGroup();
            DataGridRegestration.ItemsSource = arrStudent;

        }

        private void DataGridRegestration_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
            Button activeButton = sender as Button;
            Student activeStudent = activeButton.DataContext as Student;
            Journal activeJournal = activeButton.DataContext as Journal;
            var page = new RegEvolutionPage(activeJournal);
            this.NavigationService.Navigate(page);
            MessageBox.Show(activeStudent.IdStudent.ToString());
        }
    }
}
