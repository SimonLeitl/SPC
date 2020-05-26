using System.Collections.Generic;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SPC3.Model;
using SPC3.ViewModel;
using System.IO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

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
        public  ObservableCollection<string> _files = new ObservableCollection<string>();
        public List<string> filePaths = new List<string>();
    

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

        public void showProjekte()
        {
            string path = @"C:\Users\simonleitl\source\repos\SPC\SPC3\bin\Debug\Savings";
            
            ProcessDirectory(path);
            splitString();
        }
        public static void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}'.", path);
        }
        public void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            

            foreach (string fileName in fileEntries)  
            filePaths.Add(fileName);
            
                //ProcessFile(fileName);           
        }
        public void splitString()
        {
            for (int i = 0; i < filePaths.Count; i++){

            string name = filePaths[i];
                string[] split = Regex.Split(name, "\\");
                _files.Add(split[split.Length-1]);
                }
        }
        public ObservableCollection<string> getFileList
        {
            get
            {
                return _files;

            }
        }


        public MainViewModel()
        {
            // _projektNameEingabeView = ViewModelLocator.Instance.TestView;
            showProjekte();
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