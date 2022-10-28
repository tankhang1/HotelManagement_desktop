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
using LiveCharts;
using LiveCharts.Wpf;
namespace HotelMangement
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public Dashboard()
        {
            InitializeComponent();
            Dashboard_child dc = new Dashboard_child();
            Main.Content = dc;
        }

        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Dashboard_child dc =new Dashboard_child();
            var bc = new BrushConverter();
            dashboard_txt.Foreground = (Brush)bc.ConvertFrom("#2A7B95");
            dashboard_icon.Foreground = (Brush)bc.ConvertFrom("#2A7B95");

            Customer_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            Customer_icon.Foreground = (Brush)bc.ConvertFrom("#000000");

            Employee_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            Employee_icon.Foreground = (Brush)bc.ConvertFrom("#000000");

            Report_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            Report_icon.Foreground = (Brush)bc.ConvertFrom("#000000");

            Room_icon.Foreground = (Brush)bc.ConvertFrom("#000000");
            Room_txt.Foreground = (Brush)bc.ConvertFrom("#000000");

            Main.Content = dc;
        }

        private void StackPanel_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Customer cl = new Customer();
            var bc = new BrushConverter();
            Customer_txt.Foreground = (Brush)bc.ConvertFrom("#2A7B95");
            Customer_icon.Foreground = (Brush)bc.ConvertFrom("#2A7B95");

            Employee_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            Employee_icon.Foreground = (Brush)bc.ConvertFrom("#000000");

            Report_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            Report_icon.Foreground = (Brush)bc.ConvertFrom("#000000");

            Room_icon.Foreground = (Brush)bc.ConvertFrom("#000000");
            Room_txt.Foreground = (Brush)bc.ConvertFrom("#000000");

            dashboard_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            dashboard_icon.Foreground = (Brush)bc.ConvertFrom("#000000");

            Main.Content = cl;
        }

        private void StackPanel_PreviewMouseDown_2(object sender, MouseButtonEventArgs e)
        {
            All_Employee ae =new All_Employee();
            var bc = new BrushConverter();
            Employee_txt.Foreground = (Brush)bc.ConvertFrom("#2A7B95");
            Employee_icon.Foreground = (Brush)bc.ConvertFrom("#2A7B95");

            Report_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            Report_icon.Foreground = (Brush)bc.ConvertFrom("#000000");

            Room_icon.Foreground = (Brush)bc.ConvertFrom("#000000");
            Room_txt.Foreground = (Brush)bc.ConvertFrom("#000000");

            dashboard_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            dashboard_icon.Foreground = (Brush)bc.ConvertFrom("#000000");

            Customer_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            Customer_icon.Foreground = (Brush)bc.ConvertFrom("#000000");

            Main.Content = ae;
        }

        private void Border_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Setting st = new Setting();
            st.Show();
        }

        private void StackPanel_PreviewMouseDown_3(object sender, MouseButtonEventArgs e)
        {
            Report r = new Report();
            var bc = new BrushConverter();
            Report_txt.Foreground = (Brush)bc.ConvertFrom("#2A7B95");
            Report_icon.Foreground = (Brush)bc.ConvertFrom("#2A7B95");

            Room_icon.Foreground = (Brush)bc.ConvertFrom("#000000");
            Room_txt.Foreground = (Brush)bc.ConvertFrom("#000000");

            dashboard_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            dashboard_icon.Foreground = (Brush)bc.ConvertFrom("#000000");

            Customer_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            Customer_icon.Foreground = (Brush)bc.ConvertFrom("#000000");

            Employee_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            Employee_icon.Foreground = (Brush)bc.ConvertFrom("#000000");


            Main.Content = r;
        }

        private void StackPanel_PreviewMouseDown_4(object sender, MouseButtonEventArgs e)
        {
            Booking booking = new Booking();
            Main.Content = booking;
            var bc = new BrushConverter();
            Room_icon.Foreground = (Brush)bc.ConvertFrom("#2A7B95");
            Room_txt.Foreground = (Brush)bc.ConvertFrom("#2A7B95");

            dashboard_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            dashboard_icon.Foreground = (Brush)bc.ConvertFrom("#000000");

            Customer_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            Customer_icon.Foreground = (Brush)bc.ConvertFrom("#000000");

            Employee_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            Employee_icon.Foreground = (Brush)bc.ConvertFrom("#000000");

            dashboard_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            dashboard_icon.Foreground = (Brush)bc.ConvertFrom("#000000");

            Report_txt.Foreground = (Brush)bc.ConvertFrom("#000000");
            Report_icon.Foreground = (Brush)bc.ConvertFrom("#000000");

        }


    }
}
