﻿/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:SPC3.ViewModel"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
//using Microsoft.Practices.ServiceLocation;
using SPC3.Model;
using SPC3.SPC.Editor.Model;
using SPC3.SPC.Editor.ViewModel;
using SPC3.SPC.StartMenu.ViewModel;

namespace SPC3.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();

            //The Views
            SimpleIoc.Default.Register<ProjektNameEingabeViewModel>();
            SimpleIoc.Default.Register<StartMenuViewModel>();
            SimpleIoc.Default.Register<SteckdoseViewModel>();


        }

        private static ViewModelLocator _instance = null;

        public static ViewModelLocator Instance
        {
            get
            {
                if (_instance == null) _instance = new ViewModelLocator();
                return _instance;
            }
        }


        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public ProjektNameEingabeViewModel ProjektNameEingabeViewModel

        {
            get
            {
                return ServiceLocator.Current.GetInstance<ProjektNameEingabeViewModel>();
            }
        }
        public StartMenuViewModel StartMenuViewModel

        {
            get
            {
                return ServiceLocator.Current.GetInstance<StartMenuViewModel>();
            }
        }

        public SteckdoseViewModel steckDoseViewModel
        {
            get { return ServiceLocator.Current.GetInstance<SteckdoseViewModel>(); }
        }

        public LichtSchalterViewModel lichtSchalterViewModel
        {
            get { return ServiceLocator.Current.GetInstance<LichtSchalterViewModel>(); }
        }




        /*
                public View3ViewModel View3
                {
                    get
                    {
                        return ServiceLocator.Current.GetInstance<View3ViewModel>();
                    }
                }*/


        public static void Cleanup()
        {

        }
    }
}