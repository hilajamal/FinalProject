using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows;
using Schedule.Primitives;

namespace Schedule
{
    public class ScheduleGroupByTimeSpanGroupDescription : GroupDescription
    {
        public ScheduleGroupByTimeSpanGroupDescription()
        {
            GroupNames.Add("Larger or equal");
            GroupNames.Add("Smaller");
        }

        public TimeSpan Span
        {
            get;
            set;
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

            if ((itemEnd - itemStart) < Span)
            {
                return new object[] { GroupNames[1] };
            }
            return new object[] { GroupNames[0] };
        }
    }
}
