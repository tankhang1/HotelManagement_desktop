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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

    

        private void login_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.NavigationService.Navigate(dashboard);
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ForgotPassword fg = new ForgotPassword();
            this.NavigationService.Navigate(fg);
        }

        private void User_Name_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            User_Name.Text = "";
        }

        private void Password_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Password.Text = "";
        }
    }
}
