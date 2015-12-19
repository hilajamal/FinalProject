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
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Schedule.Primitives;
using System.Reflection;
using System.Windows.Controls.Primitives;
using System.ComponentModel;

namespace Schedule
{
    /// <summary>
    /// Control for displaying appointment information
    /// </summary>
    /// 
    [TemplatePart(Name = "PART_CELLS", Type = typeof(TimeItemsPresenter))]
    [TemplatePart(Name = "PART_HEADER", Type = typeof(TimeItemsPresenter))]
    public class Schedule : TimeItemsPresenter
    {
        private ObservableCollection<TimeItem> _cells;
        private ObservableCollection<TimeItem> _headers;
        private TimeItemsPresenter _cellsPresenter;
        private TimeItemsPresenter _headerPresenter;

        static Schedule()
        {
            // Override default styles
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Schedule), new FrameworkPropertyMetadata(typeof(Schedule)));

            // Hook up events
            EventManager.RegisterClassHandler(typeof(Schedule), TimeItem.MouseDownEvent, new RoutedEventHandler(OnTimeItemMouseDown));
            EventManager.RegisterClassHandler(typeof(Schedule), TimeItem.MouseMoveEvent, new RoutedEventHandler(OnTimeItemMouseMove));
            EventManager.RegisterClassHandler(typeof(Schedule), TimeItem.MouseUpEvent, new RoutedEventHandler(OnTimeItemMouseUp));
            EventManager.RegisterClassHandler(typeof(Schedule), TimeItem.DragEnterEvent, new RoutedEventHandler(OnTimeItemDragEnter));
            EventManager.RegisterClassHandler(typeof(Schedule), TimeItem.DragLeaveEvent, new RoutedEventHandler(OnTimeItemDragLeave));
            EventManager.RegisterClassHandler(typeof(Schedule), TimeItem.DragOverEvent, new RoutedEventHandler(OnTimeItemDragOver));
            EventManager.RegisterClassHandler(typeof(Schedule), TimeItem.DropEvent, new RoutedEventHandler(OnTimeItemDrop));
        }

        public Schedule()
        {
            _cells = new ObservableCollection<TimeItem>();
            _headers = new ObservableCollection<TimeItem>();

            HeaderItems = CollectionViewSource.GetDefaultView(_headers);
            Cells = CollectionViewSource.GetDefaultView(_cells);

            DisplayedDates = new ObservableCollection<DateTime>();
            DisplayedDates.CollectionChanged += new NotifyCollectionChangedEventHandler(DisplayedDates_CollectionChanged);
        }

        private void DisplayedDates_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (DateTime date in e.NewItems)
                    {
                        GenerateCells(date);
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (DateTime date in e.OldItems)
                    {
                        RemoveCells(date);
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    RebuildCells();        
                    break;
            }
        }

        private void RebuildCells()
        {
            _cells.Clear();
            foreach (DateTime date in DisplayedDates)
            {
                GenerateCells(date);
            }
        }

        private void RemoveCells(DateTime date)
        {
            for (int i = _cells.Count; i > 0; i--)
            {
                DateTime cellStart = TimePanel.GetItemStart(_cells[i]);
                DateTime cellEnd = TimePanel.GetItemEnd(_cells[i]);

                if (cellStart >= date && cellEnd < date.AddDays(1))
                {
                    _cells.RemoveAt(i);
                }
            }
        }

        private void GenerateCells(DateTime date)
        {
            TimeItem cell = new TimeItem();
            TimePanel.SetItemEnd(cell, date.AddDays(1));
            TimePanel.SetItemStart(cell, date);
            _cells.Add(cell);

            DateTime workingDate = date;
            while (workingDate < date.AddDays(1))
            {
                TimeItem smallCell = new TimeItem();
                TimePanel.SetItemStart(smallCell, workingDate);
                workingDate = workingDate.AddSeconds((int)ItemSize);
                TimePanel.SetItemEnd(smallCell, workingDate);
                _cells.Add(smallCell);
            }
        }

        private static ComponentResourceKey _daysGroupStyleKey;

        public static ComponentResourceKey DaysGroupStyleKey
        {
            get
            {
                if (_daysGroupStyleKey == null)
                {
                    _daysGroupStyleKey = new ComponentResourceKey(typeof(Schedule), "DaysGroupStyleKey");
                }

                return _daysGroupStyleKey;
            }
        }

        private static ComponentResourceKey _monthGroupStyleKey;

        public static ComponentResourceKey MonthGroupStyleKey
        {
            get
            {
                if (_monthGroupStyleKey == null)
                {
                    _monthGroupStyleKey = new ComponentResourceKey(typeof(Schedule), "MonthGroupStyleKey");
                }
                return _monthGroupStyleKey;
            }
        }

        private static ComponentResourceKey _dayGroupStyleKey;

        public static ComponentResourceKey DayGroupStyleKey
        {
            get
            {
                if (_dayGroupStyleKey == null)
                {
                    _dayGroupStyleKey = new ComponentResourceKey(typeof(Schedule), "DayGroupStyleKey");
                }

                return _dayGroupStyleKey;
            }
        }

        private static ComponentResourceKey _chronicalGroupStyleKey;

        public static ComponentResourceKey ChronicalStyleKey
        {
            get
            {
                if (_chronicalGroupStyleKey == null)
                {
                    _chronicalGroupStyleKey = new ComponentResourceKey(typeof(Schedule), "ChronicalStyleKey");
                }

                return _chronicalGroupStyleKey;
            }
        }

        private static ComponentResourceKey _flatStyleKey;

        public static ComponentResourceKey FlatStyleKey
        {
            get
            {
                if (_flatStyleKey == null)
                {
                    _flatStyleKey = new ComponentResourceKey(typeof(Schedule), "FlatStyleKey");
                }

                return _flatStyleKey;
            }
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
        }

        #region Layout Dependency Properties

        public Double HeaderHeight
        {
            get { return (Double)GetValue(HeaderHeightProperty); }
            set { SetValue(HeaderHeightProperty, value); }
        }

        public static readonly DependencyProperty HeaderHeightProperty =
            DependencyProperty.Register("HeaderHeight", typeof(Double), typeof(Schedule), new UIPropertyMetadata(150d));

        public Double HeaderWidth
        {
            get { return (Double)GetValue(HeaderWidthProperty); }
            set { SetValue(HeaderWidthProperty, value); }
        }

        public static readonly DependencyProperty HeaderWidthProperty =
            DependencyProperty.Register("HeaderWidth", typeof(Double), typeof(Schedule), new UIPropertyMetadata(150d));

        #endregion

        #region Logical Dependency Properties

        public ObservableCollection<DateTime> DisplayedDates
        {
            get { return (ObservableCollection<DateTime>)GetValue(DisplayedDatesProperty); }
            set { SetValue(DisplayedDatesProperty, value); }
        }

        public static readonly DependencyProperty DisplayedDatesProperty =
            DependencyProperty.Register("DisplayedDates", typeof(ObservableCollection<DateTime>), typeof(Schedule), new UIPropertyMetadata());

        private static void OnItemSizePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            Schedule schedule = (Schedule)sender;
            schedule.RebuildHeader();
        }

        public ICollectionView HeaderItems
        {
            get { return (ICollectionView)GetValue(HeaderItemsProperty); }
            set { SetValue(HeaderItemsProperty, value); }
        }

        public static readonly DependencyProperty HeaderItemsProperty =
            DependencyProperty.Register("HeaderItems", typeof(ICollectionView), typeof(Schedule), new UIPropertyMetadata());

        public ICollectionView Cells
        {
            get { return (ICollectionView)GetValue(CellsProperty); }
            set { SetValue(CellsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Cells.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CellsProperty =
            DependencyProperty.Register("Cells", typeof(ICollectionView), typeof(Schedule), new UIPropertyMetadata());



        #endregion

        #region Attached Properties

        

        #endregion

        #region Methods

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _cellsPresenter = (TimeItemsPresenter)this.GetTemplateChild("PART_CELLS");
            _headerPresenter = (TimeItemsPresenter)this.GetTemplateChild("PART_HEADER");

            AddBindings(_cellsPresenter);

            Binding cellsBinding = new Binding()
            {
                Path = new PropertyPath(Schedule.CellsProperty),
                RelativeSource = new RelativeSource(RelativeSourceMode.TemplatedParent)
            };
            _cellsPresenter.SetBinding(TimeItemsPresenter.ItemsSourceProperty, cellsBinding);

            Binding headerItemsBinding = new Binding()
            {
                Path = new PropertyPath(Schedule.HeaderItemsProperty),
                RelativeSource = new RelativeSource(RelativeSourceMode.TemplatedParent)
            };
            _headerPresenter.SetBinding(TimeItemsPresenter.ItemsSourceProperty, headerItemsBinding);

            ICollectionView view = CollectionViewSource.GetDefaultView(ItemsSource);

            if (view.CanGroup == false)
            {
                throw new Exception("Schedule control needs view that supports grouping");
            }

            ScheduleGroupByDayDescription desc = new ScheduleGroupByDayDescription(this);
            view.GroupDescriptions.Add(desc);

            ScheduleGroupByTimeSpanGroupDescription desc2 = new ScheduleGroupByTimeSpanGroupDescription();
            desc2.Span = new TimeSpan(48, 0, 0);
            view.GroupDescriptions.Add(desc2);
            
            this.GroupStyleSelector = SelectGroupStyle;

            ICollectionView cellsView = CollectionViewSource.GetDefaultView(_cells);
            ScheduleGroupByDayDescription desc3 = new ScheduleGroupByDayDescription(this);
            cellsView.GroupDescriptions.Add(desc3);

            ScheduleGroupByTimeSpanGroupDescription desc4 = new ScheduleGroupByTimeSpanGroupDescription();
            desc4.Span = new TimeSpan(24, 0, 0);
            cellsView.GroupDescriptions.Add(desc4);

            TimePanel.SetItemStart(_headerPresenter, new DateTime(1, 1, 1));
            TimePanel.SetItemEnd(_headerPresenter, new DateTime(1, 1, 2));

            _cellsPresenter.GroupStyleSelector = SelectGroupStyle;

            RebuildHeader();
        }

        private void AddBindings(TimeItemsPresenter presenter)
        {
            Binding startBinding = new Binding()
            {
                Path = new PropertyPath(TimePanel.ItemStartProperty),
                RelativeSource = new RelativeSource(RelativeSourceMode.TemplatedParent),
                NotifyOnSourceUpdated = true,
                NotifyOnTargetUpdated = true
            };
            presenter.SetBinding(TimePanel.ItemStartProperty, startBinding);

            Binding endBinding = new Binding()
            {
                Path = new PropertyPath(TimePanel.ItemEndProperty),
                RelativeSource = new RelativeSource(RelativeSourceMode.TemplatedParent),
                NotifyOnSourceUpdated = true,
                NotifyOnTargetUpdated = true
            };
            presenter.SetBinding(TimePanel.ItemEndProperty, endBinding);
        }

        private GroupStyle SelectGroupStyle(CollectionViewGroup group, int level)
        {
            GroupStyle returnStyle = null;

            switch (level)
            {
                case 0:
                    returnStyle = (GroupStyle)FindResource(DaysGroupStyleKey);
                    break;
                case 1:
                    returnStyle = (GroupStyle)FindResource(DayGroupStyleKey);
                    break;
            }

            return returnStyle;
        }

        /// <summary>
        /// Fills the header with header items
        /// </summary>
        internal void RebuildHeader()
        {
            // Clear the current header items
            _headers.Clear();

            // Set the work date
            DateTime workingDate = new DateTime(1, 1, 1);
            DateTime workingEndDate = workingDate.AddDays(1);

            // While we need to generate headers
            while (workingDate < workingEndDate)
            {
                // Generate headers!
                TimeItem item = new TimeItem();
                TimePanel.SetItemStart(item, workingDate);
                // Set the size according to the itemsize
                TimePanel.SetItemEnd(item, workingDate.AddSeconds((int)this.ItemSize));
                _headers.Add(item);

                // Add up the working date to next Item
                workingDate = workingDate.AddSeconds((int)this.ItemSize);
            }
        }

        #endregion

        #region Eventhandlers

        private static void OnTimeItemMouseUp(object sender, RoutedEventArgs e)
        {

        }

        private static void OnTimeItemMouseMove(object sender, RoutedEventArgs e)
        {
            
        }

        private static void OnTimeItemMouseDown(object sender, RoutedEventArgs e)
        {

        }

        private static void OnTimeItemDragEnter(object sender, RoutedEventArgs e)
        {

        }

        private static void OnTimeItemDragLeave(object sender, RoutedEventArgs e)
        {

        }

        private static void OnTimeItemDragOver(object sender, RoutedEventArgs e)
        {

        }

        private static void OnTimeItemDrop(object sender, RoutedEventArgs e)
        {

        }

        #endregion
    }
}
