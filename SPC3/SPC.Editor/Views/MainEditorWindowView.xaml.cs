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
using System.Windows.Shapes;
using SPC3.SPC.Editor.ViewModel;

namespace SPC3.SPC.Editor.Views
{
    /// <summary>
    /// Interaktionslogik für MainEditorWindowView.xaml
    /// </summary>
    public partial class MainEditorWindowView : Window
    {
        public MainEditorWindowView()
        {
            InitializeComponent();
           // DataContext = new KomponentenViewModel(); 
            //new LeitungenToolsViewModel();
            // new ZeichenToolsViewModel();
            /*  DataContext = new
              {
                  KomponentenToolsViewModel,
                  LeitungenToolsViewModel,
                  ZeichenToolsViewModel
              };
           }
   
           public ZeichenToolsViewModel ZeichenToolsViewModel { get; set; }
   
           public LeitungenToolsViewModel LeitungenToolsViewModel { get; set; }
   
           public KomponentenMainViewModel KomponentenToolsViewModel { get; set; }
       */
        }
    }
}
