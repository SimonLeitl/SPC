using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;

namespace SPC3.SPC.StartMenu.ViewModel
{
    public class ProjektNameEingabeViewModel : StartMenuViewModelBase
    {
        private string projektName = " ";
        public ProjektNameEingabeViewModel()
        {
            Name = "ProjektNameEingabeView";
            this.newProjektCommand = new RelayCommand(this.createNewProject);
        }

        public RelayCommand newProjektCommand { get; private set; }
        public string ProjektName
        {
            get { return projektName; }
            set { projektName = value; }
        }
        //Methode mit der das neue Projekt angelegt wird. Überprüft zunächst ob der Ordner zum Speichern vorhanden ist. Ansonsten wird ein neuer erstellt. 
        public void createNewProject()
        {
            if (checkProjectDirectory() == true)
            {
                createProjectFile();
            }
            else
            {
                createProjectDirectory();
                createProjectFile();
            }
        }

        //Methode die Überprüft ob der Ordner, in welchem die Dateien gespeichert werden, vorhanden ist
        public Boolean checkProjectDirectory()
        {
            if (Directory.Exists("Saving"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Erstellt den neuen Ordner zum Speichern der Datei
        public void createProjectDirectory()
        {
            Directory.CreateDirectory("Savings");

        }

        //Erstellt eine Datei im Format txt mit dem übergebenem Projektnamen. 
        public void createProjectFile()
        {
            String path = "savings/" + projektName + ".txt";
            using (FileStream fs = File.Create(path))
            {

            }
        }
    }
}
