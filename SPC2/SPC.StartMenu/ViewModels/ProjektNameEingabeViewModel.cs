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
            CreateNewProject();
        }

        public void CreateNewProject()
        {
            if (checkProjectDirectory() == true)
            {
                CreateProjectFile();
            }
            else
            {
                CreateProjectDirectory();
                CreateProjectFile();
            }
        }

        public Boolean checkProjectDirectory()
        {
            /**if (Directory.Exists("Saving"))
            {
                return true;
            }
            else
            {
                return false;
            }**/
            return Directory.Exists("Saving");

        }
        public void CreateProjectDirectory()
        {
            Directory.CreateDirectory("Saving");
        }

        public void CreateProjectFile()
        {
            String path = "Saving/" + "projectName" + ".txt";
            using (FileStream fs = File.Create(path))
            {

            }
        }
    }
}
