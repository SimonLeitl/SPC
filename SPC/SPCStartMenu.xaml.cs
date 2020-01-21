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
using SPC.Start_Menu;
using Microsoft.Win32;

namespace SPC
{
    /// <summary>
    /// Interaktionslogik für SPCStartMenu.xaml
    /// </summary>
    public partial class SPCStartMenu : Page
    {
        public SPCStartMenu()
        {
            InitializeComponent();
        }

        private void NewProjectbutton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Hier muss der Projektname der vom User ausgewählt wurde eingesetzt werden. 
            ProjektNameEingabe pne1 = new ProjektNameEingabe();
            pne1.Show();
            
        }

        private void LoadProjectButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {

            }
            
        }
    }
}