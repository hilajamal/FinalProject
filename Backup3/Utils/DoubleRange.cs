using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schedule.Utils
{
    public class AvailibleDoubleRange 
    {
        private double _start;
        private double _end;

        public double Start { get { return _start;  } internal set { _start = value; } }
        public double End { get { return _end; } internal set { _end = value; } }

        public AvailibleDoubleRange(double start, double end)
        {
            _start = start;
            _end = end;

            AvailibleRange = new DoubleRange[] { new DoubleRange() { Start = start, End = end } };
        }

        public DoubleRange[] AvailibleRange { get; private set; }

        public void SubtractRange(Double start, Double end)
        {
            List<DoubleRange> newRanges = new List<DoubleRange>(AvailibleRange);
            
            for (int i = newRanges.Count - 1; i >= 0; i--)
            {
                if (start <= newRanges[i].Start && end >= newRanges[i].End)
                {
                    // subtract range is larger then item, remove the item
                    newRanges.RemoveAt(i);
                }
                else if (start == newRanges[i].Start)
                {
                    // if the range start is equal to the start of the other item, adjust start
                    newRanges[i] = new DoubleRange(end, newRanges[i].End);
                }
                else if (end == newRanges[i].End)
                {
                    // if the range end is equal to the start of the other item, adjust end
                    newRanges[i] = new DoubleRange(newRanges[i].Start, start);
                }
                else if (start > newRanges[i].Start && end < newRanges[i].End)
                {
                    // split the ranges
                    DoubleRange leftRange = new DoubleRange(){ Start = newRanges[i].Start, End = start};
                    DoubleRange rightRange = new DoubleRange() { Start = end, End = newRanges[i].End };

                    newRanges.RemoveAt(i);
                    newRanges.Add(leftRange);
                    newRanges.Add(rightRange);
                }
            }

            AvailibleRange = newRanges.ToArray();
        }

        public void AddRange(DoubleRange range)
        {
            throw new NotSupportedException();
        }

        internal AvailibleDoubleRange Clone()
        {
            AvailibleDoubleRange copy = new AvailibleDoubleRange(this.Start, this.End);
            copy.AvailibleRange = this.AvailibleRange.Clone() as DoubleRange[];
            return copy;
        }
    }

    public struct DoubleRange
    {
        private double _start;
        private double _end;

        public DoubleRange(double start, double end)
        {
            _start = start;
            _end = end;
        }

        public double Start { get { return _start; } internal set { _start = value; } }
        public double End { get { return _end; } internal set { _end = value; } }
    }
}
