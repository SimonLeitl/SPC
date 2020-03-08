using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight.Command;
using SPC3.SPC.Editor.Views;

namespace SPC3.SPC.StartMenu.ViewModel
{
    public class ProjektNameEingabeViewModel : StartMenuViewModelBase
    {
        private string projektName = " ";
        public ProjektNameEingabeViewModel()
        {
            Name = "ProjektNameEingabeView";
            this.NewProjektCommand = new RelayCommand(this.CreateNewProject);
        }

        public RelayCommand NewProjektCommand { get; private set; }
        public string ProjektName
        {
            get { return projektName; }
            set { projektName = value; }
        }
        //Methode mit der das neue Projekt angelegt wird. Überprüft zunächst ob der Ordner zum Speichern vorhanden ist. Ansonsten wird ein neuer erstellt. 
        public void CreateNewProject()
        {
            if (CheckProjectDirectory() == true)
            {
                CreateProjectFile();
            }
            else
            {
                CreateProjectDirectory();
                CreateProjectFile();
            }
        }

        //Methode die Überprüft ob der Ordner, in welchem die Dateien gespeichert werden, vorhanden ist
        public Boolean CheckProjectDirectory()
        {
           /** if (Directory.Exists("Savings"))
            {
                return true;
            }
            else
            {
                return false;
            }**/
           return Directory.Exists("Savings");
        }

        //Erstellt den neuen Ordner zum Speichern der Datei
        public void CreateProjectDirectory()
        {
            Directory.CreateDirectory("Savings");

        }

        //Erstellt eine Datei im Format txt mit dem übergebenem Projektnamen. 
        public void CreateProjectFile()
        {
            String path = "Savings/" + projektName + ".txt";
            using (FileStream fs = File.Create(path))
            {

            }
            MainEditorWindowView mw = new MainEditorWindowView();
            MainWindow mainWindow = new MainWindow();
            Window Window = new Window();
            Window.Close();
            mainWindow.Close();
            // mainWindow.Hide();
           // Window.Hide();
            mw.Show();
            
            
        }
     
    }
}
