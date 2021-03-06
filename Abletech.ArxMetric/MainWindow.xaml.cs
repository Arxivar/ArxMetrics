﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Abletech.ArxMetric.Appenders;
using Abletech.ArxMetric.ViewModel;
using GalaSoft.MvvmLight.Threading;
using log4net;
using log4net.Repository.Hierarchy;

namespace Abletech.ArxMetric
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            log4net.Config.XmlConfigurator.Configure();
            DispatcherHelper.Initialize();
            TextBoxAppender.ConfigureAppender(Log);
            
            DataContext = new MainViewModel();
        }
    }
}
