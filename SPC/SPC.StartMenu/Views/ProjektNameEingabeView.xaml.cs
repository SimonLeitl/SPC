using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SPC.Start_Menu;

namespace SPC
{
    /// <summary>
    /// Interaktionslogik für ProjektNameEingabe.xaml
    /// </summary>
    public partial class ProjektNameEingabe : Page
    {
        public ProjektNameEingabe()
        {
            InitializeComponent();
        }

        private void WeiterButton_Click(object sender, RoutedEventArgs e)
        {
            String projektname;
            projektname = projektNameTextFeld.Text;
            new New_Project(projektname);

            SPCEditor e1 = new SPCEditor();
           // e1.ShowDialog();
            e1.Show();
            
            // NavigationService.Navigate(e1);

        }

        private void ZurückButton_Click(object sender, RoutedEventArgs e)
        {
            SPCStartMenu ssm1 = new SPCStartMenu();
            NavigationService.Navigate(ssm1);
        }

    }
}
