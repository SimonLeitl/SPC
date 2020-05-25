using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using SPC3.SPC.Editor.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

using System.Windows;
using System.Windows.Media;

namespace SPC3.SPC.Editor.ViewModel
{
    public class ZeichenFlaecheViewModel : INotifyPropertyChanged
    {
        private MouseBehaviour mouseBehaviour = new MouseBehaviour();
        private double _panelX;
        private double _panelY;
        private Point[] mousePosition = new Point[2];
        private System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Black,3);
        public double PanelX
        {
            get { return Math.Round(_panelX); }
            set
            {
                if (value.Equals(_panelX)) return;
                _panelX = value;
                OnPropertyChanged("PanelX");
            }
        }

        public double PanelY
        {
            get { return Math.Round(_panelY); }
            set
            {
                if (value.Equals(_panelY)) return;
                _panelY = value;
                OnPropertyChanged("PanelY");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            VerifyPropertyName(propertyName);
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [Conditional("DEBUG")]
        private void VerifyPropertyName(string propertyName)
        {
            if (TypeDescriptor.GetProperties(this)[propertyName] == null)
                throw new ArgumentNullException(GetType().Name + " does not contain property: " + propertyName);
        }

        public ICommand GetKooradinatesClickOnCanvas
        {
            get { return new RelayCommand<EventArgs>(MouseClick_ToDraw); }
        }

        public ICommand DrawLineClickOnCanvas
        {
            get { return new RelayCommand<System.Windows.Forms.PaintEventArgs>(MouseClick_ToDrawLine); }
        }

        private ObservableCollection<Line> managedLinePoints;
        public ObservableCollection<Line> ManagedLinePoints
        {
            get { return managedLinePoints; }
            set
            {
                managedLinePoints = value;
                OnPropertyChanged("ManagedLinePoints");
            }
        }

        private void MouseClick_ToDraw(EventArgs args)
        {
            MouseEventArgs e = (MouseEventArgs) args;

            if(e.LeftButton == MouseButtonState.Released) // 
            {
                if (TestArrayPosition(mousePosition) == true)
                {
                    var position = new Point();
                    position = e.GetPosition(e.Device.Target);
                    mousePosition[0] = position;
                    //count++;
                    Console.WriteLine(mousePosition[0].X + " " + mousePosition[0].Y + " erster Punkt");
                }
                else
                {
                    var position = new Point();
                    position = e.GetPosition(e.Device.Target);
                    mousePosition[1] = position;
                    //count++;
                    Console.WriteLine(mousePosition[1].X + " " + mousePosition[1].Y + " zweiter Punkt");
                    LineToDraw(mousePosition);

                    mousePosition[0] = new Point(0,0);
                    mousePosition[1] = new Point(0,0);
                }  
            }
        }

        private void MouseClick_ToDrawLine(System.Windows.Forms.PaintEventArgs painargs)
        {
            //System.Windows.Forms.PaintEventArgs graphics = (System.Windows.Forms.PaintEventArgs) args;
            painargs.Graphics.DrawLine(pen, (float)mousePosition[0].X, (float)mousePosition[0].Y, (float)mousePosition[1].X, (float)mousePosition[1].Y);

        }

        private Boolean TestArrayPosition(Point[] arrayPosition)
        {
            if (mousePosition[0] == arrayPosition[1])
            {
                return true;
            }
            return false;
        }

        public Line LineToDraw(Point[] point)
        {
            Console.WriteLine(point[0].X + " " + point[0].Y + " " + point[1].X + " " + point[1].Y + " Punkt zum Zeichnen der Linie");
            Line line = new Line();

            line.StrokeThickness = 3;
            line.Visibility = Visibility.Visible;
            line.Stroke = new SolidColorBrush(Colors.Black);
            line.X1 = point[0].X;
            line.Y1 = point[0].Y;
            line.X2 = point[1].X;
            line.Y2 = point[1].Y;

            return line;
        }
        public Point point { get; set; }
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public int StrokeThickness { get; set; }

        public Colors Stroke { get; set; }


    }
}

public class LineToDraw{


}


