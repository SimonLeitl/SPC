using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace SPC3.ViewModel
{
   public class StartMenuViewModelBase : ViewModelBase
    {
        public string _name = "";

        public String Name
        {
            get { return _name; }
            set
            {
                Set(() => Name, ref _name, value);
            }
        }
    }
}
