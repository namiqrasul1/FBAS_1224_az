﻿using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace WpfAppMap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ApplicationIdCredentialsProvider Provider { get; set; } = new(ConfigurationManager.AppSettings["bingApiKey"]);

        public MainWindow()
        {
            InitializeComponent();
            m.ZoomLevel = 15;

            DataContext = this;
            //m.Mode = new AerialMode();
            
            
        }
    }
}
