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
using System.Windows.Shapes;

namespace HotelMangement
{
    /// <summary>
    /// Interaction logic for Setting.xaml
    /// </summary>
    public partial class Setting : Window
    {
        public Setting()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            Profile_setting ps = new Profile_setting();
            Main.Content = ps;
            btn_profile.Background = (Brush)bc.ConvertFrom("#3088A4");
            //btn_night.Background = (Brush)bc.ConvertFrom("#FF9A6EEA");
            btn_password.Background = (Brush)bc.ConvertFrom("#FFFFFFFF");
            btn_addaccount.Background= (Brush)bc.ConvertFrom("#FFFFFFFF");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            btn_password.Background = (Brush)bc.ConvertFrom("#3088A4");
            btn_profile.Background = (Brush)bc.ConvertFrom("#FFFFFFFF");
            //btn_night.Background = (Brush)bc.ConvertFrom("#FF9A6EEA");
            btn_addaccount.Background = (Brush)bc.ConvertFrom("#FFFFFFFF");
            Main.Content = new Password_Setting();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            btn_password.Background = (Brush)bc.ConvertFrom("#FFFFFFFF");
            btn_profile.Background = (Brush)bc.ConvertFrom("#FFFFFFFF");
            //btn_night.Background = (Brush)bc.ConvertFrom("#FF9A6EEA");
            btn_addaccount.Background = (Brush)bc.ConvertFrom("#3088A4");
            Main.Content = new AddAccount();
        }
    }
}
