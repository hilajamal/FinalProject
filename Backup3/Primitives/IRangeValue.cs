using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schedule.Primitives
{
    public interface IRangeValue : IComparable
    {
        IRangeValue Subtract(object value);
        IRangeValue Add(object value);
        object Value { get; }
    }
}
