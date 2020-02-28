using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using SPC3.ViewModel;

namespace SPC3.SPC.Editor.ViewModel
{
    public class KomponentenMainViewModel : ViewModelBase
    {
        private List<KomponentenViewModel> _viewModelList = new List<KomponentenViewModel>();

        public List<KomponentenViewModel> ViewModelList
        {
            get
            {
                return _viewModelList;
            }
        }

        public KomponentenMainViewModel()
        {
            _viewModelList.Add(ViewModelLocator.Instance.SteckDoseViewModel);
        }
    }
}
