using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SPC.Start_Menu
{
    class New_Project
    {
        private String name;
        public New_Project(String name)
        {
            this.name = name;
            createNewProject();
        }

        //Methode mit der das neue Projekt angelegt wird. Überprüft zunächst ob der Ordner zum Speichern vorhanden ist. Ansonsten wird ein neuer erstellt. 
        public void createNewProject()
        {
            if (checkDirectory() == true)
            {
                createFile();
            }
            else
            {
                createDirectory();
            }
        }

        //Methode die Überprüft ob der Ordner, in welchem die Dateien gespeichert werden, vorhanden ist
        public Boolean checkDirectory()
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
        public void createDirectory()
        {
            Directory.CreateDirectory("Savings");
        }
        
        //Erstellt das Datei Format
        public void createFile()
        {

        }
    }
}
