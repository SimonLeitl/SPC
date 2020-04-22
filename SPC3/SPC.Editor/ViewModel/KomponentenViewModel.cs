using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GalaSoft.MvvmLight;

namespace SPC3.SPC.Editor.ViewModel
{
    public class KomponentenViewModel : ViewModelBase
    {
        public string _name;
        public string _beschreibung;
        public string _symbol;

        public string Name
        {
            get { return _name;}
            set { Set(() => Name, ref _name, value); }
        }

        public string Symbol
        {
            get { return _symbol; }
            set { Set(() => Symbol, ref _symbol, value); }
        }
    }
}
