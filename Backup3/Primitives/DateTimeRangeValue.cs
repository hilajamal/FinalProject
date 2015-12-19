using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schedule.Primitives
{
    /// <summary>
    /// Provides a wrapper around the 
    /// </summary>
    public struct DateTimeRangeValue : IRangeValue
    {
        private DateTime _value;

        public DateTimeRangeValue(DateTime value)
        {
            _value = value;
        }

        public object Value
        {
            get { return _value; }
        }

        public IRangeValue Subtract(object value)
        {
            return new TimeSpanRangeValue(_value - (DateTime)((DateTimeRangeValue)value).Value);
        }

        public IRangeValue Add(object value)
        {
            throw new NotSupportedException();
        }

        public int CompareTo(object obj)
        {
            return _value.CompareTo(((DateTimeRangeValue)obj).Value);
        }

        public int CompareTo(DateTimeRangeValue other)
        {
            return _value.CompareTo((DateTime)other.Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
