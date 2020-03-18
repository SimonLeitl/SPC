using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<String> _viewModelNameList = new ObservableCollection<string>();

        public ObservableCollection<String> ViewModelNameList
        {
            get { return _viewModelNameList; }
        }

        public List<KomponentenViewModel> ViewModelList
        {
            get
            {
                return _viewModelList;
            }
        }

        public KomponentenMainViewModel()
        {
            _viewModelList.Add(ViewModelLocator.Instance.steckDoseViewModel);
            //_viewModelList.Add(ViewModelLocator.Instance.lichtSchalterViewModel);
           
            _viewModelNameList.Add(ViewModelList[0]._name);
           
            


        }
    }
}
