using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Schedule.Primitives
{
    public class RangeTree<T> 
        where T : IRangeValue
    {
        private List<RangeNode<T>> _internalNodes;
        private Dictionary<object, RangeNode<T>> _dataIndex;
        private RangeNode<T> _rootNode;
        
        public RangeTree(T start, T end, UIElement data)
        {
            _internalNodes = new List<RangeNode<T>>();
            _dataIndex = new Dictionary<object, RangeNode<T>>();
            _rootNode = new RangeNode<T>(start, end, data);
        }

        public RangeNode<T> RootNode
        {
            get { return _rootNode; }
        }

        public void AddRangeNode(RangeNode<T> node)
        {
            if (_dataIndex.ContainsKey(node.Data))
            {
                RemoveRangeNode(_dataIndex[node.Data]);
            }

            RangeNode<T> parent = FindParentForNode(node, RootNode);
            node.Parent = parent;

            for (int i = parent.Nodes.Count - 1; i >= 0; i--)
            {
                RangeNode<T> childNode = parent.Nodes[i];

                if (node.Intersects(childNode) && node.CompareTo(childNode) == -1)
                {
                    parent.RemoveNode(childNode);
                    node.AddNode(childNode);
                    childNode.Parent = node;
                }
            }

            parent.AddNode(node);
            _internalNodes.Add(node);

            if (node.Data != null)
            {
                _dataIndex.Add(node.Data, node);
            }
        }

        public void RemoveRangeNode(RangeNode<T> node)
        {
            int index = _internalNodes.IndexOf(node);
            if (index == -1) throw new ArgumentException();

            node.Parent.RemoveNode(node);
            _internalNodes.RemoveAt(index);

            foreach (RangeNode<T> childNode in node.Nodes)
            {
                AddRangeNode(childNode);
            }
        }

        private RangeNode<T> FindParentForNode(RangeNode<T> node, RangeNode<T> parent)
        {
            RangeNode<T> returnNode = parent;

            lock (parent.Nodes)
            {
                foreach (RangeNode<T> childNode in parent.Nodes)
                {
                    if (childNode.CompareTo(node) == -1 && childNode.Intersects(node))
                    {
                        returnNode = FindParentForNode(node, childNode);
                    }
                }
            }
            return returnNode;
        }

        public RangeNode<T> GetNodeByData(object data)
        {
            if (_dataIndex.ContainsKey(data))
            {
                return _dataIndex[data];
            }
            return null;
        }

        public int GetDepth(RangeNode<T> fromNode)
        {
            int depth = 0;
            RangeNode<T> currentNode = RootNode;
            foreach (RangeNode<T> node in currentNode.Nodes)
            {
                depth = depth < node.Level ? node.Level : depth;
            }
            return depth;
        }
    }
}