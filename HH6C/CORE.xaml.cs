﻿using System;
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
using MahApps.Metro.Controls;
using System.Data.SQLite;
using WpfApp6.View;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfApp6.Model;

namespace WpfApp6
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    /// 

    public partial class Core : MetroWindow
    {
        private static System.Timers.Timer aTimer;

        private ViewModel VM => this.DataContext as ViewModel;
        public bool bindingMENU_finale { get; set; }
        public bool bindingMENU_detailyastatistiky { get; set; }
        public bool bindingMENU_online { get; set; }

        public Core()
        {
            this.DataContext = new ViewModel();
            InitializeComponent();
            VM.SQL_OPENCONNECTION();
            VM.SQL_READDATA("select hodnota from nastaveni where polozka='pozadi'", "pozadi");
            VM.SQL_READDATA("select hodnota from nastaveni where polozka='popredi' ", "popredi");
            //MahApps.Metro.ThemeManager.ChangeTheme(Application.Current, pozadi[pouzitepozadi], barva[pouzitabarva]);
            bindingMENU_finale = true ;
            bindingMENU_detailyastatistiky = false ;
            bindingMENU_online = false;


        }




        private void HamburgerMenuControl_OnItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs e)
        {
            //this.HamburgerMenuControl.Content = e.InvokedItem;
            //this.HamburgerMenuControl.DataContext = Pohledy.Test.DataContextProperty;
        }










        private void core_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            VM.SQL_CLOSECONNECTION();
        }

        private void CLICK_changeforeground(object sender, RoutedEventArgs e)
        {
            VM.Function_global_changeforeground = VM.Function_global_changeforeground + 1;
        }

        private void CLICK_changebackground(object sender, RoutedEventArgs e)
        {
            VM.Function_global_changebackground = VM.Function_global_changebackground + 1;

        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //        aTimer = new System.Timers.Timer(20000);
            //          aTimer.Start();
//            this.Show();
  //          System.Threading.Thread.Sleep(500);
            HamburgerMenuControl.SelectedIndex = 0;

        }
    }
}
