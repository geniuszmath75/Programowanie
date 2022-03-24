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

namespace EdytorTekstu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ZmienKolor()
        {
            byte r = (byte)Slajder2.Value;
            byte g = (byte)Slajder3.Value;
            byte b = (byte)Slajder4.Value;

            Color c = Color.FromRgb(r, g, b);
            SolidColorBrush cb = new SolidColorBrush(c);
            Blok.Background = cb;
        }

        private void Slajder2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ZmienKolor();
        }

        private void Slajder3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ZmienKolor();
        }

        private void Slajder4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ZmienKolor();
        }
    }
}