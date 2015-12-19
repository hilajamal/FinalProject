//---------------------------------------------------------------------------
//
// Copyright (C) Inter Access B.V..  All rights reserved.
//
//---------------------------------------------------------------------------

using System;
using System.Collections;
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
using System.Collections.Generic;
using Schedule.Utils;

namespace Schedule.Primitives
{
    /// <summary>
    /// Panel that displays TimeItems. 
    /// TimeItems that intersect with the TimePanel get displayed
    /// </summary>
    public class TimePanel : Panel
    {
        static TimePanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TimePanel), new FrameworkPropertyMetadata(typeof(TimePanel)));
        }

        public TimePanel()
        {
           
        }

        #region Dependency Properties

        ///// <summary>
        ///// DateTime to present from
        ///// </summary>
        //public DateTime Start
        //{
        //    get { return (DateTime)GetValue(StartProperty); }
        //    set { SetValue(StartProperty, value); }
        //}

        //public static readonly DependencyProperty StartProperty =
        //    DependencyProperty.Register(
        //        "Start",
        //        typeof(DateTime),
        //        typeof(TimePanel),
        //        new FrameworkPropertyMetadata()
        //        {
        //            AffectsMeasure = true,
        //            AffectsArrange = true
        //        });

        ///// <summary>
        ///// DateTime to present to
        ///// </summary>
        //public DateTime End
        //{
        //    get { return (DateTime)GetValue(EndProperty); }
        //    set { SetValue(EndProperty, value); }
        //}

        //public static readonly DependencyProperty EndProperty =
        //    DependencyProperty.Register(
        //        "End",
        //        typeof(DateTime),
        //        typeof(TimePanel),
        //        new FrameworkPropertyMetadata()
        //        {
        //            AffectsMeasure = true,
        //            AffectsArrange = true
        //        });

        /// <summary>
        /// The minimum height of the selected ItemSize, used with vertical orientation
        /// </summary>
        public double MinimumTimePeriodHeight
        {
            get { return (double)GetValue(MinimumTimePeriodHeightProperty); }
            set { SetValue(MinimumTimePeriodHeightProperty, value); }
        }

        public static readonly DependencyProperty MinimumTimePeriodHeightProperty =
            DependencyProperty.Register("MinimumTimePeriodHeight", typeof(double), typeof(TimePanel), new UIPropertyMetadata(50d));

        /// <summary>
        /// The minimum height of the selected ItemSize, used with horizontal orientation
        /// </summary>
        public double MinimumTimePeriodWidth
        {
            get { return (double)GetValue(MinimumTimePeriodWidthProperty); }
            set { SetValue(MinimumTimePeriodWidthProperty, value); }
        }

        public static readonly DependencyProperty MinimumTimePeriodWidthProperty =
            DependencyProperty.Register("MinimumTimePeriodWidth", typeof(double), typeof(TimePanel), new UIPropertyMetadata(50d));

        /// <summary>
        /// The granuality of the TimePanel, the large the timespan the smaller the TimePanel.
        /// </summary>
        public TimeItemSize ItemSize
        {
            get { return (TimeItemSize)GetValue(ItemSizeProperty); }
            set { SetValue(ItemSizeProperty, value); }
        }

        public static readonly DependencyProperty ItemSizeProperty =
            DependencyProperty.Register("ItemSize", typeof(TimeItemSize), typeof(TimePanel),
            new FrameworkPropertyMetadata()
            {
                AffectsMeasure = true,
                AffectsArrange = true
            });

        #endregion

        #region Attached Properties

        /// <summary>
        /// Returns the DateTime for the ItemStart property of the item
        /// </summary>
        /// <param name="obj">Item to get start DateTime from</param>
        /// <returns>Start DateTime from item, 1-1-0001 if empty</returns>
        public static DateTime GetItemStart(DependencyObject obj)
        {
            return (DateTime)obj.GetValue(ItemStartProperty);
        }

        /// <summary>
        /// Sets the DateTime for the ItemStart property
        /// </summary>
        /// <param name="obj">Item to set the start DateTime from</param>
        /// <param name="value">DateTime to set the item to</param>
        public static void SetItemStart(DependencyObject obj, DateTime value)
        {
            obj.SetValue(ItemStartProperty, value);
        }

        /// <summary>
        /// Attached Property of the start DateTime of the TimeItem
        /// </summary>
        public static readonly DependencyProperty ItemStartProperty =
            DependencyProperty.RegisterAttached(
                "ItemStart",
                typeof(DateTime),
                typeof(TimePanel),
                new FrameworkPropertyMetadata(OnItemStartChanged, OnItemStartCoerce)
                {
                    AffectsMeasure = true,
                    AffectsArrange = true
                });


        /// <summary>
        /// Returns the DateTime for the ItemEnd property of the item
        /// </summary>
        /// <param name="obj">Item to get end DateTime from</param>
        /// <returns>End DateTime from item, 1-1-0001 if empty</returns>
        public static DateTime GetItemEnd(DependencyObject obj)
        {
            return (DateTime)obj.GetValue(ItemEndProperty);
        }

        /// <summary>
        /// Sets the DateTime for the ItemEnd property
        /// </summary>
        /// <param name="obj">Item to set the end DateTime from</param>
        /// <param name="value">DateTime to set the item to</param>
        public static void SetItemEnd(DependencyObject obj, DateTime value)
        {
            obj.SetValue(ItemEndProperty, value);
        }

        /// <summary>
        /// Attached property of the end DateTime of a TimeItem
        /// </summary>
        public static readonly DependencyProperty ItemEndProperty =
            DependencyProperty.RegisterAttached(
                "ItemEnd",
                typeof(DateTime),
                typeof(TimePanel),
                new FrameworkPropertyMetadata(OnItemEndChanged, OnItemEndCoerce)
                {
                    AffectsMeasure = true,
                    AffectsArrange = true
                });

        #endregion

        private static void OnItemStartChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Visual reference = d as Visual;
            if (reference != null)
            {
                if (reference is TimePanel)
                {
                    // reset the tree, if a valid End is set
                    if (TimePanel.GetItemEnd(reference) > (DateTime)e.NewValue)
                    {
                        ((TimePanel)reference).ResetTree();
                    }
                }
                else
                {
                    TimePanel parent = VisualTreeHelper.GetParent(reference) as TimePanel;
                    if (parent != null && e.NewValue != e.OldValue && TimePanel.GetItemEnd(d) > (DateTime)e.NewValue)
                    {
                        RangeNode<DateTimeRangeValue> targetNode = parent._internalTree.GetNodeByData(d);
                        if (targetNode != null)
                        {
                            parent._internalTree.RemoveRangeNode(targetNode);
                        }

                        RangeNode<DateTimeRangeValue> newNode = new RangeNode<DateTimeRangeValue>(
                            new DateTimeRangeValue((DateTime)e.NewValue),
                            new DateTimeRangeValue(TimePanel.GetItemEnd(d)),
                            (UIElement)d);
                        parent._internalTree.AddRangeNode(newNode);
                    }
                }
            }
        }

        private void ResetTree()
        {
            DateTimeRangeValue start = new DateTimeRangeValue(TimePanel.GetItemStart(this));
            DateTimeRangeValue end = new DateTimeRangeValue(TimePanel.GetItemEnd(this));
            _internalTree = new RangeTree<DateTimeRangeValue>(start, end, this);

            lock (Children.SyncRoot)
            {
                foreach (UIElement child in Children)
                {
                    DateTimeRangeValue childStart = new DateTimeRangeValue(TimePanel.GetItemStart(child));
                    DateTimeRangeValue childEnd = new DateTimeRangeValue(TimePanel.GetItemEnd(child));
                    RangeNode<DateTimeRangeValue> node = new RangeNode<DateTimeRangeValue>(childStart, childEnd, child);
                }
            }
        }

        private static void OnItemEndChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Visual reference = d as Visual;
            if (reference != null)
            {
                if (reference is TimePanel)
                {
                    // reset the tree, if a valid End is set
                    if ((DateTime)e.NewValue > TimePanel.GetItemStart(reference))
                    {
                        ((TimePanel)reference).ResetTree();
                    }
                }
                else
                {
                    TimePanel parent = VisualTreeHelper.GetParent(reference) as TimePanel;
                    if (parent != null && e.NewValue != e.OldValue && (DateTime)e.NewValue > TimePanel.GetItemStart(d))
                    {
                        RangeNode<DateTimeRangeValue> targetNode = parent._internalTree.GetNodeByData(d);
                        if (targetNode != null)
                        {
                            parent._internalTree.RemoveRangeNode(targetNode);
                        }

                        RangeNode<DateTimeRangeValue> newNode = new RangeNode<DateTimeRangeValue>(
                            new DateTimeRangeValue(TimePanel.GetItemStart(d)),
                            new DateTimeRangeValue((DateTime)e.NewValue),
                            (UIElement)d);
                        parent._internalTree.AddRangeNode(newNode);
                    }
                }
            }
        }

        private static object OnItemStartCoerce(DependencyObject d, object baseValue)
        {
            return baseValue;
        }

        private static object OnItemEndCoerce(DependencyObject d, object baseValue)
        {
            return baseValue;
        }

        private static void OnColumnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        private static void OnColumnSpanChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        protected override Size MeasureOverride(Size availableSize)
        {
            DateTime Start = TimePanel.GetItemStart(this);
            DateTime End = TimePanel.GetItemEnd(this);

            if (Start > End) throw new ArgumentException("Start cannot be afther End");

            Size actualSize = new Size();
            double unitsPerSecond = 0;
            double totalSeconds = (End - Start).TotalSeconds;

            switch (LogicalOrientation)
            {
                case Orientation.Horizontal:
                    actualSize = new Size(
                        (totalSeconds / 3600) * MinimumTimePeriodWidth, availableSize.Height);
                    unitsPerSecond = actualSize.Width / (End - Start).TotalSeconds;
                    break;
                case Orientation.Vertical:
                    actualSize = new Size(
                        availableSize.Width, (totalSeconds / 3600) * MinimumTimePeriodHeight);
                    unitsPerSecond = actualSize.Height / (End - Start).TotalSeconds;
                    break;
            }
            if (Double.IsInfinity(unitsPerSecond) || Double.IsNaN(unitsPerSecond))
            {
                return actualSize;
            }

            foreach (UIElement child in this.Children)
            {
                RangeNode<DateTimeRangeValue> node = _internalTree.GetNodeByData(child);
                int intersectionCount = node.Level + node.GetMaxChildCount();

                DateTime childStart = TimePanel.GetItemStart(child);
                DateTime childEnd = TimePanel.GetItemEnd(child);

                DateTime start = childStart < Start ? Start : childStart;
                DateTime end = childEnd > End ? End : childEnd;

                if (start < end)
                {
                    double height = unitsPerSecond * (end - start).TotalSeconds;
                    double width = (availableSize.Width / intersectionCount);
                    Size size = new Size();
                    size.Height = height;
                    size.Width = width;
                    child.Measure(size);
                }
            }

            return actualSize;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            DateTime Start = TimePanel.GetItemStart(this);
            DateTime End = TimePanel.GetItemEnd(this);

            if (Start > End) throw new ArgumentException("Start cannot be afther End");

            double unitsPerSecond = 0;

            switch (LogicalOrientation)
            {
                case Orientation.Horizontal:
                    unitsPerSecond = finalSize.Width / (End - Start).TotalSeconds;
                    break;
                case Orientation.Vertical:
                    unitsPerSecond = finalSize.Height / (End - Start).TotalSeconds;
                    break;
            }
            if (Double.IsInfinity(unitsPerSecond) || Double.IsNaN(unitsPerSecond)) return finalSize;

            AvailibleDoubleRange range = new AvailibleDoubleRange(0, finalSize.Width);
            for (int i = _internalTree.RootNode.Nodes.Count - 1; i >= 0; i--)
            {
                ArrangeChild(_internalTree.RootNode.Nodes[i], range, Start, End, unitsPerSecond);
            }
            return finalSize;
        }

        private void ArrangeChild(RangeNode<DateTimeRangeValue> node, AvailibleDoubleRange range, DateTime Start, DateTime End, Double unitsPerSecond)
        {
            double width = 0;
            double x = 0;

            x = range.AvailibleRange[0].Start;

            // Build a better one,.. if two elements can fit in the gap,..
            if (range.AvailibleRange.Length > 1)
            {
                // Fill the gap
                width = range.AvailibleRange[0].End - range.AvailibleRange[0].Start;
            }
            else
            {
                // Set the first availible range and devide
                int itemsLeft = node.GetMaxChildCount() + 1;
                //int itemsLeft = _internalTree.Depth - node.Level;
                width = (range.AvailibleRange[0].End - range.AvailibleRange[0].Start) / itemsLeft;
            }

            // Get the start and end properties
            DateTime start = TimePanel.GetItemStart(node.Data);
            DateTime end = TimePanel.GetItemEnd(node.Data);

            // If they are out of bounds, limit them to TimePanel start and end
            start = start < Start ? Start : start;
            end = end > End ? End : end;

            if (start < end)
            {
                // Calculate height and width
                double height = unitsPerSecond * (end - start).TotalSeconds;

                // Calculate y
                double y = unitsPerSecond * (start - Start).TotalSeconds;

                // Make a new Rect and arrange!
                Rect box = new Rect(x, y, width, height);
                node.Data.Arrange(box);
            }

            AvailibleDoubleRange newRange = range.Clone();
            newRange.SubtractRange(x, x + width);

            for (int i = node.Nodes.Count - 1; i >= 0; i--)
            {
                ArrangeChild(node.Nodes[i], newRange, Start, End, unitsPerSecond);
            }
        }

        private RangeTree<DateTimeRangeValue> _internalTree = null;

        protected override void OnVisualChildrenChanged(DependencyObject visualAdded, DependencyObject visualRemoved)
        {
            base.OnVisualChildrenChanged(visualAdded, visualRemoved);
            
            if (visualAdded != null)
            {
                if (_internalTree.GetNodeByData(visualAdded) == null)
                {
                    DateTime start = TimePanel.GetItemStart(visualAdded);
                    DateTime end = TimePanel.GetItemEnd(visualAdded);

                    if (start < end)
                    {
                        _internalTree.AddRangeNode(
                            new RangeNode<DateTimeRangeValue>(
                                new DateTimeRangeValue(start),
                                new DateTimeRangeValue(end),
                                (UIElement)visualAdded));
                    }
                }
            }

            if (visualRemoved != null)
            {

            }
        }
    }
}
