using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC2.SPC.StartMenu.ViewModels
{
    class ProjektNameEingabeViewModel : INotifyPropertyChanged
    {
        private String projectName;
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public ProjektNameEingabeViewModel(String projectName)
        {
            this.projectName = projectName;
            createNewProject();
        }

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
        public void createProjectDirectory()
        {
            Directory.CreateDirectory("Saving");
        }

        public void createProjectFile()
        {
            String path = "Saving/" + "projectName" + ".txt";
            using (FileStream fs = File.Create(path))
            {

            }
        }
    }
}
