using System;
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

namespace EF4
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        private ypEntities yp = new ypEntities();
        public FirstPage()
        {
            InitializeComponent();
            grid_dep.ItemsSource = yp.Departments.ToList();
            Combo_dep.ItemsSource = yp.Departments.ToList();
            Combo_dep.DisplayMemberPath = "name_dep";

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            grid_dep.ItemsSource = yp.Departments.ToList();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

            grid_dep.ItemsSource = yp.Departments.ToList().Where(item => item.name_dep.Contains(name_dep.Text));
        }

        private void Combo_dep_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Combo_dep.SelectedItem != null)
            {
                var s = Combo_dep.SelectedItem as Departments;
                grid_dep.ItemsSource = yp.Departments.ToList().Where(item => item.name_dep == s.name_dep);
            }
        }
    }
}
