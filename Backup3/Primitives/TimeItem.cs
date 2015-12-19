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

namespace Schedule.Primitives
{
    /// <summary>
    /// Represents an item that can be place in a TimePanel
    /// </summary>
    public class TimeItem : ContentControl
    {
        public TimeItem()
        {
            
        }

        static TimeItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TimeItem), new FrameworkPropertyMetadata(typeof(TimeItem)));
        }

        #region Properties

        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register("IsSelected", typeof(bool), typeof(TimeItem), new UIPropertyMetadata(false));

        #endregion
    }
}