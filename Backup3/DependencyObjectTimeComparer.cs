//---------------------------------------------------------------------------
//
// Copyright (C) Inter Access B.V..  All rights reserved.
//
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows;

namespace Schedule.Primitives
{
    /// <summary>
    /// Compares two time items based on size and start time
    /// </summary>
    internal class DependencyObjectTimeComparer : IComparer<DependencyObject>, IComparer
    {
        public int Compare(DependencyObject x, DependencyObject y)
        {
            // largest item
            TimeSpan spanX = TimePanel.GetItemEnd(x) - TimePanel.GetItemStart(x);
            TimeSpan spanY = TimePanel.GetItemEnd(y) - TimePanel.GetItemStart(y);

            if (spanX < spanY) return 1;
            if (spanX > spanY) return -1;

            // item with the earlyest start time
            if (TimePanel.GetItemStart(x) > TimePanel.GetItemStart(y)) return 1;
            if (TimePanel.GetItemStart(x) < TimePanel.GetItemStart(y)) return -1;

            // items are the same
            return 0;
        }

        public int Compare(object x, object y)
        {
            if (!(x is DependencyObject) || !(y is DependencyObject))
            {
                throw new NotSupportedException();
            }

            return this.Compare((DependencyObject)x, (DependencyObject)y);
        }

    }
}
