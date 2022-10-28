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

namespace HotelMangement
{
    /// <summary>
    /// Interaction logic for All_Employee.xaml
    /// </summary>
    public partial class All_Employee : Page
    {
        public All_Employee()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeeProfile profile = new EmployeeProfile();
            this.NavigationService.Navigate(profile);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Add_New_Employee ane =new Add_New_Employee();
            this.NavigationService.Navigate(ane);
        }
    }
}
