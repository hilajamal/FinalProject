using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Schedule;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Schedule.Primitives;

namespace TestApplication
{
    /// <summary>
    /// Interaction logic for ScheduleControl.xaml
    /// </summary>
    public partial class ScheduleControl : Window
    {
        public ScheduleControl()
        {
            InitializeComponent();
        }

        private void StartDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            SetDisplayedDates();
        }

        private void EndDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            SetDisplayedDates();
        }

        private void SetDisplayedDates()
        {
            if (StartDatePicker == null || EndDatePicker == null || Scheduler == null) return;

            DateTime startDate = Convert.ToDateTime(StartDatePicker.SelectedDate);
            DateTime endDate = Convert.ToDateTime(EndDatePicker.SelectedDate);

            if (startDate > endDate)
            {
                startDate = endDate;
                endDate = Convert.ToDateTime(StartDatePicker.SelectedDate);
            }

            if (startDate != null || endDate != null)
            {
                ObservableCollection<DateTime> dateRange = new ObservableCollection<DateTime>();
                while (startDate <= endDate)
                {
                    dateRange.Add(startDate);
                    startDate = startDate.AddDays(1);
                }

                Scheduler.DisplayedDates = dateRange;
            }
        }

        int teller = 6;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppointmentCollection collection = (AppointmentCollection)this.FindResource("Appointments");

            switch (teller)
            {
                case 1:
                    collection.Add(
                        new Appointment()
                        {
                            Start = new DateTime(2009, 8, 14, 0, 0, 0),
                            End = new DateTime(2009, 8, 15, 0, 0, 0),
                            Title = "Test1"
                        }
                    );
                    break;
                case 2:
                    collection.Add(
                        new Appointment()
                        {
                            Start = new DateTime(2009, 8, 14, 0, 0, 0),
                            End = new DateTime(2009, 8, 14, 2, 0, 0),
                            Title = "Test2"
                        }
                    );
                    break;
                case 3:
                    collection.Add(
                        new Appointment()
                        {
                            Start = new DateTime(2009, 8, 14, 2, 0, 0),
                            End = new DateTime(2009, 8, 14, 4, 0, 0),
                            Title = "Test3"
                        }
                    );
                    break;
                case 4:
                    collection.Add(
                        new Appointment()
                        {
                            Start = new DateTime(2009, 8, 14, 0, 0, 0),
                            End = new DateTime(2009, 8, 14, 4, 0, 0),
                            Title = "Test4"
                        }
                    );
                    break;
                case 5:
                    collection.Add(
                        new Appointment()
                        {
                            Start = new DateTime(2009, 8, 14, 4, 0, 0),
                            End = new DateTime(2009, 8, 14, 23, 0, 0),
                            Title = "Test5"
                        }
                    );
                    break;
                case 6:
                    collection.Add(
                        new Appointment()
                        {
                            Start = new DateTime(2009, 8, 14, 19, 0, 0),
                            End = new DateTime(2009, 8, 14, 22, 0, 0),
                            Title = "Test6"
                        }
                    );
                    break;
                case 7:
                    collection.Add(
                        new Appointment()
                        {
                            Start = new DateTime(2009, 8, 14, 12, 0, 0),
                            End = new DateTime(2009, 8, 14, 23, 0, 0),
                            Title = "Test7"
                        }
                    );
                    break;
                case 8:
                    collection.Add(
                        new Appointment()
                        {
                            Start = new DateTime(2009, 8, 14, 22, 30, 0),
                            End = new DateTime(2009, 8, 14, 23, 0, 0),
                            Title = "Test8"
                        }
                    );
                    break;
                case 9:
                    collection.Add(
                        new Appointment()
                        {
                            Start = new DateTime(2009, 8, 14, 21, 0, 0),
                            End = new DateTime(2009, 8, 14, 23, 30, 0),
                            Title = "Test9"
                        }
                    );
                    break;
                case 10:
                    collection.Add(
                        new Appointment()
                        {
                            Start = new DateTime(2009, 8, 14, 1, 0, 0),
                            End = new DateTime(2009, 8, 14, 23, 0, 0),
                            Title = "Test10"
                        }
                    );
                    break;
                case 11:
                    collection.Add(
                        new Appointment()
                        {
                            Start = new DateTime(2009, 8, 14, 1, 0, 0),
                            End = new DateTime(2009, 8, 15, 2, 0, 0),
                            Title = "Test11"
                        }
                    );
                    break;
                case 12:
                    collection.Add(
                        new Appointment()
                        {
                            Start = new DateTime(2009, 8, 14, 0, 0, 0),
                            End = new DateTime(2009, 8, 18, 0, 0, 0),
                            Title = "Test12"
                        }
                    );
                    break;
            }
            teller++;
        }
    }
}
