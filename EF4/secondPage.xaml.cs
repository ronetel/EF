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
    /// Логика взаимодействия для secondPage.xaml
    /// </summary>
    public partial class secondPage : Page
    {
        private ypEntities yp = new ypEntities();
        public secondPage()
        {
            InitializeComponent();
            grid_emp.ItemsSource = yp.Employees.ToList();
            Combo_emp.ItemsSource = yp.Positions.ToList();
            Combo_emp.DisplayMemberPath = "title";
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            grid_emp.ItemsSource = yp.Employees.ToList().Where(item => item.name_emp.Contains(name_emp.Text));
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            grid_emp.ItemsSource = yp.Employees.ToList();
        }

        private void Combo_emp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Combo_emp.SelectedItem != null)
            {
                var s = (Combo_emp.SelectedItem as Positions);
                
                grid_emp.ItemsSource = yp.Employees.ToList().Where(item => item.position_id == s.id_position);
            }
        }
    }
}
