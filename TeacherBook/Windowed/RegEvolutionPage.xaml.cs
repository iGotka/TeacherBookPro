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
    /// Логика взаимодействия для RegEvolutionPage.xaml
    /// </summary>
    public partial class RegEvolutionPage : Page
    {
        public RegEvolutionPage(Journal currentElement)
        {
            InitializeComponent();
            this.DataContext = currentElement;
            List<Journal> arrJournal = JournalController.GetJournal();
            List<Student> arrStudent = StudentController.GetStudent();
            List<Group> arrGroup = GroupController.GetGroup();
            List<Subject> arrSubject = SubjectController.GetSubject();
            GroupComboBox.ItemsSource = arrGroup.ToList();
            StudentComboBox.ItemsSource = arrStudent.ToList();
            SubjectComboBox.ItemsSource = arrSubject.ToList();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            int group = Convert.ToInt32(GroupComboBox.SelectedValue);
            int student = Convert.ToInt32(StudentComboBox.SelectedValue);
            int subject = Convert.ToInt32(SubjectComboBox.SelectedValue);
            int evalution = Convert.ToInt32(EvolutionTextBox.Text);

           
            //if (JournalController.PUTJournal(idJournal,newEvolution))
            //{
            //    this.NavigationService.Navigate(new PrepodPage());
            //    MessageBox.Show("нифига добавилось!!!!!!!!!");
            //}
            //else
            //{
            //    MessageBox.Show("нифига не добавилось");
            //}
        }

        private void StudentComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SubjectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void GroupComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EvolutionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
