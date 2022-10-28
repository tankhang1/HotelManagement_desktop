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
    /// Interaction logic for Booking.xaml
    /// </summary>
    public partial class Booking : Page
    {
        public Booking()
        {
            InitializeComponent();
            string[] FloorName = { "Mot", "Hai", "Ba", "Bon" };
            int[] NumberOfRoom = { 10, 21, 10, 12 };
            for (int k = 0; k < FloorName.Length; ++k)
            {
                int count = NumberOfRoom[k];
                Grid Floor = new Grid();
                TextBlock txtBlock1 = new TextBlock();
                txtBlock1.Text = "Tang " + FloorName[k];
                txtBlock1.FontSize = 30;
                txtBlock1.VerticalAlignment = VerticalAlignment.Top;

                RoomList.Children.Add(txtBlock1);

                int Column = 5, Row = (count % 5 == 0) ? count / 5 : count / 5 + 1;
                while (Column > 0)
                {
                    ColumnDefinition gridCol1 = new ColumnDefinition();
                    gridCol1.Width = new GridLength(100);
                    Floor.ColumnDefinitions.Add(gridCol1);
                    --Column;
                }
                while (Row > 0)
                {
                    RowDefinition gridRow1 = new RowDefinition();
                    gridRow1.Height = new GridLength(50);
                    Floor.RowDefinitions.Add(gridRow1);
                    --Row;
                }
                Border Outline = new Border();
                Outline.BorderThickness = new Thickness(2);
                Outline.BorderBrush = Brushes.Black;
                Outline.CornerRadius = new CornerRadius(20);
                Outline.Child = Floor;
                RoomList.Children.Add(Outline);
                for (int i = 0; i < count; i++)
                {
                    {
                        Button MyControl = new Button();
                        MyControl.Background = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#3ba7ca")); ;
                        MyControl.Height = 25;
                        MyControl.Width = 75;
                        MyControl.Content = (i + 1).ToString();
                        MyControl.Name = "Button" + (i + 1).ToString();
                        Grid.SetColumn(MyControl, i % 5);
                        Grid.SetRow(MyControl, i / 5);
                        Floor.Children.Add(MyControl);
                    }
                    Floor.SetValue(Grid.ColumnProperty, i);
                }
            }
        }
    }
}
