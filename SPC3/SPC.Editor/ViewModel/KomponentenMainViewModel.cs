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
        // public ObservableCollection<String> _viewModelNameList = new ObservableCollection<string>();
        public List<String> _viewModelNameList = new List<string>();
        public ObservableCollection<string> _viewModelSymbolList = new ObservableCollection<string>();
        /* public ObservableCollection<String> ViewModelNameList
         {
             get { return _viewModelNameList; }
         }*/
        
             public List<String> ViewModelNameList
             {
                 get { return _viewModelNameList; }
             }
            
            
        public ObservableCollection<string> ViewModelSymbolList
        {
            get
            {
                return _viewModelSymbolList;
           
            }
        }

        public List<KomponentenViewModel> ViewModelList
        {
            get
            {
                return _viewModelList;
            }
        }
        public string imageSource
        {
            get
                {
                return @"C:\Users\simonleitl\source\repos\SPC\SPC3\SPC.Editor\KomponentenPictures\steckdose.png";
            }
        
        }
        public KomponentenMainViewModel()
        {
            _viewModelList.Add(ViewModelLocator.Instance.steckDoseViewModel);
            _viewModelList.Add(ViewModelLocator.Instance.lichtSchalterViewModel);
            //_viewModelList.Add(ViewModelLocator.Instance.lichtSchalterViewModel);
           
            

            _viewModelNameList.Add(ViewModelList[0]._name);
            _viewModelNameList.Add(ViewModelList[1]._name);

            _viewModelSymbolList.Add(ViewModelList[0]._symbol);
           
            
        }
    }
}
