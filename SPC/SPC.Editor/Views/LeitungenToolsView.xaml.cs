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

namespace SPC.SPC.Editor.Views
{
    /// <summary>
    /// Interaktionslogik für LeitungenToolsView.xaml
    /// </summary>
    public partial class LeitungenToolsView : UserControl
    {
        public LeitungenToolsView()
        {
            InitializeComponent();
        }

        public SPC.MainWindow MainWindow
        {
            get => default(SPC.SPC.MainWindow);
            set
            {
            }
        }
    }
}
