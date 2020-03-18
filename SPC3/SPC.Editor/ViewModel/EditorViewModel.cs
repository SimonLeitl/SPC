using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SPC3.SPC.Editor.Views;
using SPC3.ViewModel;

namespace SPC3.SPC.Editor.ViewModel
{
    public class EditorViewModel : ViewModelBase
    {
        private RelayCommand<EditorMainViewModelBase> _changeCommand;
        private EditorMainViewModelBase _currentPageViewModel;
        private RelayCommand<EditorMainViewModelBase> _change;
        private EditorMainViewModelBase _leitungenToolsViewModel = ViewModelLocator.Instance.LeitungenToolsViewModel;
        private ListBox Ltvm;

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
          /*  ListBox leitungenListBox = new ListBox();
            List<LeitungenToolsViewModel> leitungenToolsViewList = new List<LeitungenToolsViewModel>();
            leitungenToolsViewList.Add(new LeitungenToolsViewModel(){Name = "test"});
            leitungenToolsViewList.Add(new LeitungenToolsViewModel() { Name = "test1" });
            leitungenToolsViewList.Add(new LeitungenToolsViewModel() { Name = "test2" });
            foreach (var VARIABLE in leitungenToolsViewList)
            {
                LeitungenView.SelectedItems.Add(VARIABLE);
            }
            */
            SetLeitungenToolsView = _leitungenToolsViewModel;
            CurrentPageViewModel = _leitungenToolsViewModel;
        }

        public ListBox LeitungenView
        {
            get => Ltvm;
            set => Ltvm = value;
        }

        public RelayCommand BindLeitungenToolsViewModel { get; set; }

        public RelayCommand<EditorMainViewModelBase> GetPageCommand { get; private set; }

        public RelayCommand<EditorMainViewModelBase> GetPage { get; set; }

        public EditorViewModel()
        {
            BindLeitungenToolsViewModel = new RelayCommand(ChangeToLeitungenToolsView);
            _viewModelList.Add(ViewModelLocator.Instance.LeitungenToolsViewModel);

            _currentPageViewModel = _leitungenToolsViewModel;
        }

    }
}
