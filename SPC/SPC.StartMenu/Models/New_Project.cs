using System.IO;

namespace SPC.SPC.StartMenu.Models
{
    internal class New_Project
    {
        private readonly string name;

        public New_Project(string name)
        {
            this.name = name;
            createNewProject();
        }

        //Methode mit der das neue Projekt angelegt wird. Überprüft zunächst ob der Ordner zum Speichern vorhanden ist. Ansonsten wird ein neuer erstellt. 
        public void createNewProject()
        {
            if (checkDirectory())
            {
                createFile();
            }
            else
            {
                createDirectory();
                createFile();
            }
        }

        //Methode die Überprüft ob der Ordner, in welchem die Dateien gespeichert werden, vorhanden ist
        public bool checkDirectory()
        {
            if (Directory.Exists("Saving"))
                return true;
            return false;
        }

        //Erstellt den neuen Ordner zum Speichern der Datei
        public void createDirectory()
        {
            Directory.CreateDirectory("Savings");
        }

        //Erstellt eine Datei im Format txt mit dem übergebenem Projektnamen. 
        public void createFile()
        {
            var path = "savings/" + name + ".txt";
            using (var fs = File.Create(path))
            {
            }
        }
    }
}