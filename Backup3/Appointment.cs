//---------------------------------------------------------------------------
//
// Copyright (C) Inter Access B.V..  All rights reserved.
//
//---------------------------------------------------------------------------

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
using Schedule.Primitives;
using System.ComponentModel;

namespace Schedule
{
    /// <summary>
    /// This class can be used to feed the schedule control with appointment information.
    /// You can make your own implementation, it only requires a Start and End DateTime properties
    /// In the future we will change this, so any class can go into the schedule control
    /// </summary>
    public class Appointment : INotifyPropertyChanged
    {

        public Appointment()
        {
           
        }

        private DateTime _start;
        public DateTime Start
        {
            get
            {
                return _start;
            }
            set
            {
                _start = value;
                RaisePropertyChanged("Start");
            }
        }

        private DateTime _end;
        public DateTime End
        {
            get
            {
                return _end;
            }
            set
            {
                _end = value;
                RaisePropertyChanged("End");
            }
        }

        private string _location;
        public string Location
        {
            get { return _location; }
            set
            {
                _location = value;
                RaisePropertyChanged("Location");
            }
        }

        private string _summary;
        public string Summary
        {
            get { return _summary; }
            set
            {
                _summary = value;
                RaisePropertyChanged("Summary");
            }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged("Title");
            }
        }

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    

        public event PropertyChangedEventHandler  PropertyChanged;
    }
}
