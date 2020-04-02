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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using SPC3.SPC.Editor.Views;
using System.Drawing;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace SPC3.SPC.Editor.ViewModel
{
   public class ZeichenFlaecheViewModel : INotifyPropertyChanged
    {
        private double _panelX;
        private double _panelY;
        private ArrayList _mousePosition = new ArrayList();

        public double PanelX
        {
            get { return _panelX; }
            set
            {
                if (value.Equals(_panelX)) return;
                _panelX = value;
                OnPropertyChanged("PanelX");
            }
        }

        public double PanelY
        {
            get { return _panelY; }
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

        private void Canvas_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                _mousePosition.Add(_panelX);
                _mousePosition.Add(_panelY);
            }

            if (e.ClickCount == 2)
            {
                _mousePosition.Add(_panelX);
                _mousePosition.Add(_panelY);

            }
               
        }

       private void DrawLine() { 
                Line line = new Line();

                line.Stroke = SystemColors.WindowFrameBrush;
                line.X1 = (double) _mousePosition[0];
                line.Y1 = (double) _mousePosition[1];
                line.X2 = (double) _mousePosition[2];
                line.Y2 = (double) _mousePosition[3];

        }
    }
}
