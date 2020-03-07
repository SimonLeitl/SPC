using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace SPC3.SPC.Editor.ViewModel
{
    public class EditorMainViewModelBase : ViewModelBase
    {
        public string _Name = "";

        public String Name
        {
            get { return _Name; }
            set
            {
                Set(() => Name, ref _Name, value);
            }
        }
    }
}
