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
    /// Interaction logic for ForgotPassword_2.xaml
    /// </summary>
    public partial class ForgotPassword_2 : Page
    {
        public ForgotPassword_2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login lg = new Login();
            this.NavigationService.Navigate(lg);
        }
    }
}
