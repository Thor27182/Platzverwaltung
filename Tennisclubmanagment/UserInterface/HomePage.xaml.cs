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
    /// Interaktionslogik für HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            DatePicker datePickerWithBlackoutDates = new DatePicker();
            //var today = DateTime.Today;
            //dp.SelectedDate = today;

            //datePickerWithBlackoutDates.DisplayDateStart = new DateTime(2020, 1, 1);
            //datePickerWithBlackoutDates.DisplayDateEnd = new DateTime(2030, 1, 31);
            //datePickerWithBlackoutDates.SelectedDate = today;

            //datePickerWithBlackoutDates.BlackoutDates.Add(new CalendarDateRange(new DateTime(2020, 1, 1), today));
            setButtons(); 
        }

        private void setButtons()
        {
            for (int i = 4; i <= 12; i++)
            {
                for (int j = 4; j <= 7; j++)
                {
                    Button b = new Button();
                    b.Content = "Frei";
                    b.Background = Brushes.White;
                    b.Click += SlotButtonClick;
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                    grid.Children.Add(b);
                }
            }
        }
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

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var picker = sender as DatePicker;
            DateTime? date = picker.SelectedDate;
            setButtons();
        }
    }
}
