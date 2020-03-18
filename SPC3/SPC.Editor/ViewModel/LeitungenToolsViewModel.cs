using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using System.Windows.Controls;

namespace SPC3.SPC.Editor.ViewModel
{
    public class LeitungenToolsViewModel : ViewModelBase
    {
        public string _name;
        public string _beschreibung;
        public Image _Image;

        public string Name
        {
            get { return _name; }
            set { Set(() => Name, ref _name, value); }
        }
    }
}
