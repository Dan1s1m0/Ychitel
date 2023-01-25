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
using Ychitel.Model;

namespace Ychitel.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        Core db = new Core();
        List<Students> arrayStudents;
        int idGroup;
        int idStudent;
        int idProfession;
        public EditPage()
        {
            InitializeComponent();
            EditGroupComboBox.ItemsSource = db.context.Groups.ToList();
            EditGroupComboBox.DisplayMemberPath = "NameGroup";
            EditGroupComboBox.SelectedValuePath = "IdGroup";

            EditStudentCombBox.DisplayMemberPath = "FIO";
            EditStudentCombBox.SelectedValuePath = "IdStudent";

            EditParaComboBox.ItemsSource = db.context.Professions.ToList();
            EditParaComboBox.DisplayMemberPath = "NameProfession";
            EditParaComboBox.SelectedValuePath = "IdProfession";
        }

        private void EditGroupComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EditStudentCombBox.IsEnabled = true;
            idGroup = Convert.ToInt32(EditGroupComboBox.SelectedValue);
            EditStudentCombBox.ItemsSource = db.context.Students.Where(x => x.IdGroup == idGroup).ToList();
        }

        private void EditStudentCombBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EditParaComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EdittOcenkuButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
