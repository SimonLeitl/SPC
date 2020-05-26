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
        private ObservableCollection<KomponentenViewModel> _viewModelList = new ObservableCollection<KomponentenViewModel>();
        // public ObservableCollection<String> _viewModelNameList = new ObservableCollection<string>();
        public List<string> _viewModelNameList = new List<string>();
        public List<string> _viewModelSymbolList = new List<string>();
        /* public ObservableCollection<String> ViewModelNameList
         {
             get { return _viewModelNameList; }
         }*/
        
             public List<string> ViewModelNameList
             {
                 get { return _viewModelNameList; }
             }
            
            
        public List<string> ViewModelSymbolList
        {
            get
            {
                return _viewModelSymbolList;
           
            }
        }

        public ObservableCollection<KomponentenViewModel> ViewModelList
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
            _viewModelSymbolList.Add(ViewModelList[1]._symbol);
           
            
        }
    }
}
