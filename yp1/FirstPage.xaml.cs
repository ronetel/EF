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
using yp1.DataSet1TableAdapters;

namespace yp1
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {

        private ypEntities2 content = new ypEntities2();
        public FirstPage()
        {
            InitializeComponent();
            grid_dep.ItemsSource = content.Departments.ToList();
        }
    }
}
