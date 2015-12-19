using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Data;
using System.Collections.ObjectModel;
using System.Windows;

namespace Schedule.Primitives
{
    public class RangeNode<T> : INotifyPropertyChanged, IComparable<RangeNode<T>>
        where T : IRangeValue
    {
        private List<RangeNode<T>> _internalNodes;
        private ReadOnlyCollection<RangeNode<T>> _internalCollectionView;
        private UIElement _data;

        public RangeNode(T start, T end, UIElement data)
        {
            _internalNodes = new List<RangeNode<T>>();
            _start = start;
            _end = end;
            _internalCollectionView = new ReadOnlyCollection<RangeNode<T>>(_internalNodes);
            _data = data;
        }

        private T _start;
        private T _end;

        public T Start { get { return _start; } }
        public T End { get { return _end; } }
        
        private event PropertyChangedEventHandler _propertyChangedEvent;

        public event PropertyChangedEventHandler PropertyChanged
        {
            add { _propertyChangedEvent += value; }
            remove { _propertyChangedEvent -= value; }
        }

        protected void RaiseOnPropertyChanged(string propertyName)
        {
            if (_propertyChangedEvent != null)
            {
                _propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public bool Intersects(RangeNode<T> target)
        {
            return 
                End.CompareTo(target.Start) > 0 &&
                Start.CompareTo(target.End) < 0;
        }

        public int CompareTo(RangeNode<T> other)
        {
            IRangeValue range = this.End.Subtract(this.Start);
            IRangeValue range2 = other.End.Subtract(other.Start);

            // largest first
            if (range.CompareTo(range2) == -1) return 1;
            if (range.CompareTo(range2) == 1) return -1;

            // item with the earlyest start time
            return this.Start.CompareTo(other.Start);
        }

        public RangeNode<T> Copy()
        {
            return new RangeNode<T>(this.Start, this.End, this.Data);
        }

        public ReadOnlyCollection<RangeNode<T>> Nodes
        {
            get { return _internalCollectionView; }
        }

        public RangeNode<T> Parent
        {
            get;
            internal set;
        }

        public int Level
        {
            get
            {
                if (Parent == null) return 1;
                return Parent.Level + 1;
            }
        }

        public int GetMaxChildCount()
        {
            int maxChildNodeCount = 0;

            foreach (RangeNode<T> childNode in _internalNodes)
            {
                int childNodeCount = childNode.GetMaxChildCount();
                maxChildNodeCount = maxChildNodeCount > childNodeCount ? maxChildNodeCount : childNodeCount;
            }

            if (_internalNodes.Count > 0) maxChildNodeCount++;
            return maxChildNodeCount;
        }

        public bool IsLeaf()
        {
            return _internalNodes.Count == 0;
        }

        public UIElement Data
        {
            get { return _data; }
            set { _data = value; }
        }

        internal void AddNode(RangeNode<T> node)
        {
            _internalNodes.Add(node);
            _internalNodes.Sort();
        }

        internal void RemoveNode(RangeNode<T> node)
        {
            _internalNodes.Remove(node);
        }
    }  
}