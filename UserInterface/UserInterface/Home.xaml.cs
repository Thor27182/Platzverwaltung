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
    /// Interaktionslogik für Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            DatePicker datePickerWithBlackoutDates = new DatePicker();
            var today = DateTime.Today;

            //datePickerWithBlackoutDates.DisplayDateStart = new DateTime(2020, 1, 1);
            //datePickerWithBlackoutDates.DisplayDateEnd = new DateTime(2030, 1, 31);
            //datePickerWithBlackoutDates.SelectedDate = today;

            //datePickerWithBlackoutDates.BlackoutDates.Add(new CalendarDateRange(new DateTime(2020, 1, 1), today));

            for (int i = 4; i <= 12; i++)
            {
                for (int j = 4; j <= 7; j++)
                {
                    Button b = new Button();
                    b.Content = string.Format("Row: {0}, Column: {1}", i, j);
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                    grid.Children.Add(b);
                }
            }
        }
    }
}
