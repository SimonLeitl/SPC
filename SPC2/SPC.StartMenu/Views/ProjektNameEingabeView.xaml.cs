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
    /// Interaktionslogik für ProjektNameEingabeView.xaml
    /// </summary>
    public partial class ProjektNameEingabeView : Page
    {
        StartMenuViewModel startMenuViewModel=new StartMenuViewModel();
        public ProjektNameEingabeView()
        {
            InitializeComponent();
            this.DataContext = startMenuViewModel;

        }
    }
}
