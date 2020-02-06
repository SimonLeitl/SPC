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
using System.IO;
using System.Collections;

namespace SPC
{
    /// <summary>
    /// Interaktionslogik für SPCStartMenu.xaml
    /// </summary>
    public partial class SPCStartMenu : Page
    {
        private string[] viewProjectFiles;
        public ArrayList arrayList;
        private String path = "savings/";
        public SPCStartMenu sPCStartMenu;
        public String ProjectView { get; set; }

        public SPCStartMenu()
        {
            InitializeComponent();

           arrayList = new ArrayList();
           viewProjectFiles = Directory.GetFiles(path);
           for (int i = 1; i <= viewProjectFiles.Length; i++)
           {
                arrayList.Add(viewProjectFiles[i-1]);
                 // viewUsedProjects.Items.Add(viewProjectFiles[i-1]);
            };
           viewUsedProjects.ItemsSource = arrayList;
            





        }

        private void NewProjectbutton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Hier muss der Projektname der vom User ausgewählt wurde eingesetzt werden. 
            ProjektNameEingabe pne1 = new ProjektNameEingabe();
            NavigationService.Navigate(pne1);
           
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