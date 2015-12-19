using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schedule.Primitives
{
    public class DoubleRangeValue : IRangeValue
    {
        private double _value;

        public DoubleRangeValue(double value)
        {
            _value = value;
        }

        public IRangeValue Subtract(object value)
        {
            return new DoubleRangeValue(_value - (double)value);
        }

        public IRangeValue Add(object value)
        {
            return new DoubleRangeValue(_value + (double)value);
        }

        public object Value
        {
            get { return _value; }
        }

        public int CompareTo(object obj)
        {
            return _value.CompareTo(((DoubleRangeValue)obj).Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
