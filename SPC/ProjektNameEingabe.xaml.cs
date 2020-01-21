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
using System.Windows.Shapes;
using SPC.Start_Menu;

namespace SPC
{
    /// <summary>
    /// Interaktionslogik für ProjektNameEingabe.xaml
    /// </summary>
    public partial class ProjektNameEingabe : Window
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
            this.Close();
        }
    }
}
