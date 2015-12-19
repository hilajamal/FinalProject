using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Schedule.Primitives;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Schedule
{
    public class ScheduleGroupByDayDescription : GroupDescription
    {
        private Schedule _owner;

        public ScheduleGroupByDayDescription(Schedule owner)
        {
            _owner = owner;
            owner.DisplayedDates.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(DisplayedDates_CollectionChanged);

            foreach (DateTime date in _owner.DisplayedDates)
            {
                GroupNames.Add(date);
            }
        }

        void DisplayedDates_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (DateTime date in e.NewItems)
                    {
                        GroupNames.Add(date);
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (DateTime date in e.NewItems)
                    {
                        GroupNames.Remove(date);
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    GroupNames.Clear();
                    foreach (DateTime date in _owner.DisplayedDates)
                    {
                        GroupNames.Add(date);
                    }
                    break;
            }
        }

        public override object GroupNameFromItem(object item, int level, System.Globalization.CultureInfo culture)
        {
            DateTime itemEnd;
            DateTime itemStart;
            List<DateTime> groupNames = new List<DateTime>();

            if (item is Appointment)
            {
                Appointment app = (Appointment)item;

                itemEnd = app.End;
                itemStart = app.Start;
            }
            else if (item is DependencyObject)
            {
                DependencyObject o = (DependencyObject)item;
                itemStart = TimePanel.GetItemStart(o);
                itemEnd = TimePanel.GetItemEnd(o);
            }
            else
            {
                throw new NotSupportedException();
            }

            foreach (DateTime groupName in _owner.DisplayedDates)
            {
                if (
                    itemEnd > groupName &&
                    itemStart < groupName.AddDays(1))
                {
                    groupNames.Add(groupName);
                }
            }

            return groupNames.ToArray();
        }
    }
}
