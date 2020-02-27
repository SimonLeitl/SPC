using System.Collections.Generic;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SPC3.Model;
using SPC3.ViewModel;

namespace SPC3.SPC.StartMenu.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private RelayCommand<StartMenuViewModelBase> _changePageCommand;
        private StartMenuViewModelBase _currentPageViewModel;
        private RelayCommand<StartMenuViewModelBase> _changePage;
        private StartMenuViewModelBase _projektNameEingabeViewModel = ViewModelLocator.Instance.ProjektNameEingabeViewModel;
        private StartMenuViewModelBase _startMenuViewModel = ViewModelLocator.Instance.StartMenuViewModel;

        private List<StartMenuViewModelBase> _viewModelList = new List<StartMenuViewModelBase>();

        public StartMenuViewModelBase ProjektNameEingabeViewModel
        {
            get { return _projektNameEingabeViewModel; }
        }
        public List<StartMenuViewModelBase> ViewModelList
        {
            get
            {
                return _viewModelList;
            }
        }



        public StartMenuViewModelBase CurrentPageViewModel
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

        public StartMenuViewModelBase setProjektNameEingabeView
        {
            get { return _projektNameEingabeViewModel; }
            set { Set(() => setProjektNameEingabeView, ref _projektNameEingabeViewModel, value); }

        }

        public void ChangeToProjektNameEingabeView()
        {

            // _projektNameEingabeViewModel = ViewModelLocator.Instance.TestView;
            setProjektNameEingabeView = _projektNameEingabeViewModel;
            CurrentPageViewModel = _projektNameEingabeViewModel;
        }
        public void ChangeToStartMenuView()
        {
            CurrentPageViewModel = _startMenuViewModel;
        }

        public RelayCommand OeffneProjektNameEingabeCommand { get; set; }
        public RelayCommand ZurueckButtonCommand { get; set; }

        public RelayCommand<StartMenuViewModelBase> ChangePageCommand { get; private set; }

        public RelayCommand<StartMenuViewModelBase> ChangePage
        {
            get; set;

        }




        public MainViewModel()
        {
            // _projektNameEingabeView = ViewModelLocator.Instance.TestView;

            OeffneProjektNameEingabeCommand = new RelayCommand(ChangeToProjektNameEingabeView);
            ZurueckButtonCommand = new RelayCommand(ChangeToStartMenuView);
            ChangePageCommand = new RelayCommand<StartMenuViewModelBase>(p => ChangePageAction(p));


            _viewModelList.Add(ViewModelLocator.Instance.ProjektNameEingabeViewModel);


            // _viewModelList.Add(ViewModelLocator.Instance.View3);

            _currentPageViewModel = _startMenuViewModel;
        }

        private void ChangePageAction(StartMenuViewModelBase viewModel)
        {
            CurrentPageViewModel = viewModel;
            //CurrentPageViewModel = ViewModelList.FirstOrDefault(vm => vm == viewModel);
            // CurrentPageViewModel = ViewModelList.
        }
    }
}