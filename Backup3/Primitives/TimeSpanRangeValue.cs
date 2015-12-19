using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schedule.Primitives
{
    public class TimeSpanRangeValue : IRangeValue
    {
        private TimeSpan _value;

        public TimeSpanRangeValue(TimeSpan value)
        {
            _value = value;
        }

        public IRangeValue Subtract(object value)
        {
            throw new NotImplementedException();
        }

        public IRangeValue Add(object value)
        {
            throw new NotImplementedException();
        }

        public object Value
        {
            get { return _value; }
        }

        public int CompareTo(object obj)
        {
            return _value.CompareTo(((TimeSpanRangeValue)obj).Value);
        }
    }
}
