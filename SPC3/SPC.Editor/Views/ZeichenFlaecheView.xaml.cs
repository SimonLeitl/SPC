using System;
using System.Collections;
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
using SPC3.SPC.Editor.ViewModel;

namespace SPC3.SPC.Editor.Views
{
    /// <summary>
    /// Interaktionslogik für ZeichenFlaecheView.xaml
    /// </summary>
    public partial class ZeichenFlaecheView : UserControl
    {
       /** ArrayList _mousePosition = new ArrayList();
        private Canvas canvas = new Canvas();
        ZeichenFlaecheViewModel test = new ZeichenFlaecheViewModel();
        private MouseBehaviour mousebehav = new MouseBehaviour();
        private Point p;*/
        public ZeichenFlaecheView()
        {
            InitializeComponent();
        }

       /** private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                //MessageBox.Show("Mouse click event handled!");
                _mousePosition.Add(100.0);
                _mousePosition.Add(100.0);
            }

            if (e.ClickCount == 2)
            {
                p = new Point(p.X, p.Y);
                _mousePosition.Add(100.0);
                _mousePosition.Add(400.0);
                int test = _mousePosition.Count;
                for (int i = 0; i < _mousePosition.Count; i++)
                {

                }
                MessageBox.Show(mousebehav.MouseX + "Fabian bringt den Laptop zum explodieren" + mousebehav.MouseY);
                DrawLine();
            }

        }

        private void DrawLine()
        {
            Line line = new Line();

            line.Stroke = SystemColors.WindowFrameBrush;
            line.X1 = (double)_mousePosition[0];
            line.Y1 = (double)_mousePosition[1];
            line.X2 = (double)_mousePosition[2];
            line.Y2 = (double)_mousePosition[3];

        }*/
    }
}
