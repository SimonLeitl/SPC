using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SPC3.ViewModel;

namespace SPC3.SPC.Editor.ViewModel
{
    public class EditorViewModel : ViewModelBase
    {
        private RelayCommand<EditorMainViewModelBase> _changeCommand;
        private EditorMainViewModelBase _currentPageViewModel;
        private RelayCommand<EditorMainViewModelBase> _change;
        private EditorMainViewModelBase _leitungenToolsViewModel = ViewModelLocator.Instance.LeitungenToolsViewModel;

        private List<EditorMainViewModelBase> _viewModelList = new List<EditorMainViewModelBase>();

        public EditorMainViewModelBase LeitungenToolsViewModel
        {
            get { return _leitungenToolsViewModel; }
        }

        public List<EditorMainViewModelBase> viewmodelList
        {
            get { return _viewModelList; }
        }

        public EditorMainViewModelBase CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                Set(() => CurrentPageViewModel, ref _currentPageViewModel, value);
            }
        }

        public EditorMainViewModelBase SetLeitungenToolsView
        {
            get { return _leitungenToolsViewModel; }
            set { Set(() => SetLeitungenToolsView, ref _leitungenToolsViewModel, value); }

        }

        public void ChangeToLeitungenToolsView()
        {
            SetLeitungenToolsView = _leitungenToolsViewModel;
            CurrentPageViewModel = _leitungenToolsViewModel;
        }

        public RelayCommand BindLeitungenToolsView { get; set; }

        public RelayCommand<EditorMainViewModelBase> GetPageCommand { get; private set; }

        public RelayCommand<EditorMainViewModelBase> GetPage { get; set; }

        public EditorViewModel()
        {
            BindLeitungenToolsView = new RelayCommand(ChangeToLeitungenToolsView);
            _viewModelList.Add(ViewModelLocator.Instance.LeitungenToolsViewModel);

            _currentPageViewModel = _leitungenToolsViewModel;
        }

    }
}
