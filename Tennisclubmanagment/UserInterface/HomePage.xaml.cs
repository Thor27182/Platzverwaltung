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

namespace UserInterface
{
    /// <summary>
<<<<<<<< HEAD:Tennisclubmanagment/UserInterface/HomePage.xaml.cs
    /// Interaktionslogik für HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
========
    /// Interaktionslogik für Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
>>>>>>>> f80994c459e9becbdaf99e6bc62332578fb2082e:Tennisclubmanagment/UserInterface/Home.xaml.cs
        {
            InitializeComponent();
            DatePicker datePickerWithBlackoutDates = new DatePicker();
            var today = DateTime.Today;
<<<<<<<< HEAD:Tennisclubmanagment/UserInterface/HomePage.xaml.cs
            dp.SelectedDate = today;
========

>>>>>>>> f80994c459e9becbdaf99e6bc62332578fb2082e:Tennisclubmanagment/UserInterface/Home.xaml.cs
            //datePickerWithBlackoutDates.DisplayDateStart = new DateTime(2020, 1, 1);
            //datePickerWithBlackoutDates.DisplayDateEnd = new DateTime(2030, 1, 31);
            //datePickerWithBlackoutDates.SelectedDate = today;

            //datePickerWithBlackoutDates.BlackoutDates.Add(new CalendarDateRange(new DateTime(2020, 1, 1), today));

            for (int i = 4; i <= 12; i++)
            {
                for (int j = 4; j <= 7; j++)
                {
                    Button b = new Button();
<<<<<<<< HEAD:Tennisclubmanagment/UserInterface/HomePage.xaml.cs
                    b.Content = "Frei";
                    b.Background = Brushes.White;
                    b.Click += SlotButtonClick;
========
                    b.Content = string.Format("Row: {0}, Column: {1}", i, j);
>>>>>>>> f80994c459e9becbdaf99e6bc62332578fb2082e:Tennisclubmanagment/UserInterface/Home.xaml.cs
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                    grid.Children.Add(b);
                }
            }
        }
<<<<<<<< HEAD:Tennisclubmanagment/UserInterface/HomePage.xaml.cs

        private void SlotButtonClick(object sender, RoutedEventArgs e)
        {
            ChangeButtonLayout(sender);
        }

        private void ChangeButtonLayout(object sender)
        {
            if(((Control)sender).Background == Brushes.White)
            {
                ((Control)sender).Background = Brushes.Yellow;

                var button = ((Control)sender);
                var cIndex = Grid.GetColumn(button);
                var rIndex = Grid.GetRow(button);

                (sender as Button).Content = "Ausgewählt";
            }
            else if(((Control)sender).Background == Brushes.Yellow)
            {
                ((Control)sender).Background = Brushes.White;
                (sender as Button).Content = "Frei";
            }
        }
========
>>>>>>>> f80994c459e9becbdaf99e6bc62332578fb2082e:Tennisclubmanagment/UserInterface/Home.xaml.cs
    }
}
