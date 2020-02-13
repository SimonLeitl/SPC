using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SPC2.SPC.StartMenu.ViewModels
{
    class StartMenuViewModel : INotifyPropertyChanged
    {
        Binding binding = new Binding("openProjektNameEingabeView");
        
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public StartMenuViewModel()
        {
           

        }

        public void openProjektNameEingabeView()
        {

        }

    }
}
