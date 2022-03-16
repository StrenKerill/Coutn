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
using ClassLibrary;

namespace WpfApp3.Pages
{
    /// <summary>
    /// Логика взаимодействия для MultiplyPage.xaml
    /// </summary>
    public partial class MultiplyPage : Page
    {
        public MultiplyPage()
        {
            InitializeComponent();
        }

        private void BtnMul(object sender, RoutedEventArgs e)
        {
            double a, b;
            if(double.TryParse(this.a.Text, out a) && double.TryParse(this.b.Text, out b))
            {
                double c;
                string result = "";
                MulNum.MN(a, b, out c);
                if (!double.IsNaN(c)) result += $"{c}";
                this.result.Text = result;
            }
        }
    }
}
