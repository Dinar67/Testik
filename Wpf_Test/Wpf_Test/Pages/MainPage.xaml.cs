using System.Collections;
using System.Collections.Generic;
using System.Windows.Controls;
using Wpf_Test.Components;

namespace Wpf_Test.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            

            PersonControl control1 = new PersonControl();
            PersonControl control2 = new PersonControl();
            PersonControl control3 = new PersonControl();
            PersonControl control4 = new PersonControl();

            control1.GetFIO("John", "Name", "PatrJohn");
            control2.GetFIO("Dino", "erw", "rsaw");
            control3.GetFIO("Janie", "dggd", "eg");
            control4.GetFIO("ejf", "ser", "uiljh");

            MyPanel.Children.Add(control1);
            MyPanel.Children.Add(control2);
            MyPanel.Children.Add(control3);
            MyPanel.Children.Add(control4);

        }
    }
}
