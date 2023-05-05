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
    /// Логика взаимодействия для AddStudentPage.xaml
    /// </summary>
    public partial class AddStudentPage : Page
    {
        public AddStudentPage()
        {
            InitializeComponent();
            List<Profession> arrProfession = ProfessionController.GetProfession();
            List<FormTime> arrFormTime = FormTimesController.GetFormTime();
            List<Group> arrGroup = GroupController.GetGroup();
            List<YearAdd> arrYearAdd = YearAddController.GetYearAdd();
            GroupComboBox.ItemsSource = arrGroup.ToList();
            ProfessionComboBox.ItemsSource = arrProfession.ToList();
            YearComboBox.ItemsSource = arrYearAdd.ToList();
            FormTimeComboBox.ItemsSource = arrFormTime.ToList();
        }

        private void LastNameTextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void ProfessionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

     

        private void StudentAddButton_Click(object sender, RoutedEventArgs e)
        {
            int group = Convert.ToInt32(GroupComboBox.SelectedValue);
            int profession = Convert.ToInt32(ProfessionComboBox.SelectedValue);
            int yearadd = Convert.ToInt32(YearComboBox.SelectedValue);
            int formtime = Convert.ToInt32(FormTimeComboBox.SelectedValue);
            string firstname = (FirstNameTextBox.Text);
            string lastname = (LastNameTextBox.Text);
            string patronymicname = (PatronymicNameTextBox.Text);

            Student newStudent = new Student
            {
                IdGroup = group,
                IdProfession = profession,
                IdYearAdd = yearadd,
                FiestName = firstname,
                LastName = lastname,
                PatronomicName = patronymicname,
                IdFormTime = formtime
            };
            if (StudentController.POSTStudent(newStudent))
            {
                this.NavigationService.Navigate(new PrepodPage());
                MessageBox.Show("нифига добавилось!!!!!!!!!");
            }
            else
            {
                MessageBox.Show("нифига не добавилось");
            }
        }
    }
}
