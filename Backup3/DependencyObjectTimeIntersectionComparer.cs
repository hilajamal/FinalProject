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

namespace Schedule.Primitives
{
    /// <summary>
    /// Comparer that compares if two items intersect
    /// Returns -1 when x appears before y
    /// Returns 1 when x appears after y
    /// Returns 0 if the items intersect
    /// </summary>
    internal class DependencyObjectTimeIntersectionComparer : IComparer<DependencyObject>
    {
        public int Compare(DependencyObject x, DependencyObject y)
        {
            // X before Y?
            if (TimePanel.GetItemEnd(x) <= TimePanel.GetItemStart(y)) return -1;
            // Y before X?
            if (TimePanel.GetItemStart(x) >= TimePanel.GetItemEnd(y)) return 1;

            // Intersect
            return 0;
        }
    }
}
