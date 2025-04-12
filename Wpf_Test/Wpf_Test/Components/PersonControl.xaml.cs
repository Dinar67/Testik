using System.Windows.Controls;

namespace Wpf_Test.Components
{
    /// <summary>
    /// Логика взаимодействия для PersonControl.xaml
    /// </summary>
    public partial class PersonControl : UserControl
    {
        public string Surname;
        public string Firstname;
        public string Patronymic;

        public void GetFIO(string surname, string name, string patr)
        {
            Surname = surname;
            Firstname = name;
            Patronymic = patr;
            NameTb.Text = $"{Surname} {Firstname} {Patronymic}";
        }

        public PersonControl()
        {
            InitializeComponent();
        }
    }
}
