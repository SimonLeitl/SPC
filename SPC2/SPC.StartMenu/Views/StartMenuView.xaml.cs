using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SPC2.SPC.StartMenu.ViewModels;

namespace SPC2.SPC.StartMenu.Views
{
    /// <summary>
    /// Interaktionslogik für StartMenuView.xaml
    /// </summary>
    public partial class StartMenuView : Window
    {
        StartMenuViewModel startMenuViewModel = new StartMenuViewModel();
        public StartMenuView()
        {
            InitializeComponent();
            DataContext = startMenuViewModel;

        }

       // private void ProjektErstellen(object sender, RoutedEventArgs e)
       // {

       // }

      //  private void ProjektOffnen(object sender, RoutedEventArgs e)
       // {

       // }
    }
}
