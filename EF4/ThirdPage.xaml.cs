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
    /// Логика взаимодействия для ThirdPage.xaml
    /// </summary>
    public partial class ThirdPage : Page
    {
        private ypEntities yp = new ypEntities();
        public ThirdPage()
        {
            InitializeComponent();
            grid_pos.ItemsSource = yp.Positions.ToList();
            Combo_pos.ItemsSource = yp.Departments.ToList();
            Combo_pos.DisplayMemberPath = "name_dep";
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            grid_pos.ItemsSource = yp.Positions.ToList().Where(item => item.title.Contains(title.Text));
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            grid_pos.ItemsSource = yp.Positions.ToList();
        }

        private void Combo_pos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Combo_pos.SelectedItem != null)
            {
                var s = Combo_pos.SelectedItem as Departments;
                grid_pos.ItemsSource = yp.Positions.ToList().Where(item => item.department_id == s.id_department);
            }
        }
    }
}
