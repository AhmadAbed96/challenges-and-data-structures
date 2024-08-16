using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class Binary_Search_Tree
    {
        public TNode Root { get; set; }

        public Binary_Search_Tree(int RootVal)
        {
            Root = new TNode(RootVal);  
        }

        public void Add(int val)
        {
            Add( Root, val);
        }

        private void Add(TNode node, int value)
        {
            if (value < node.Value)
            {
                if (node.left == null)
                {
                    node.left = new TNode(value);
                }
                else
                {
                    Add(node.left, value);
                }
            }
            else
            {
                if(node.Right == null)
                {
                    node.Right = new TNode(value);
                }
                else
                {
                    Add(node.Right, value);
                }
            }
        }

        public bool Contain(int val)
        {
            return Contains(Root, val);
        }
        private bool Contains( TNode node, int val)
        {
            if (node == null)
            {
                return false;
            }
            if(node.Value == val)
            {
                return true;
            }
            if(val < node.Value)
            {
                return Contains(node.left, val);
            }
            else return Contains(node.Right, val);
        }

        public void Remove(int data) => Remove(Root, data);

        public TNode Remove(TNode Root, int data)
        {
            if (Root == null) return null;
            if (data < Root.Value)
            {
                Root.left = Remove(Root.left, data);
            }
            else if (data > Root.Value)
            {
                Root.Right = Remove(Root.Right, data);
            }
            else
            {
                if (Root.left == null && Root.Right == null)
                {
                    return null;
                }
                if (Root.left == null)
                {
                    return Root.Right;
                }
                if (Root.Right == null)
                {
                    return Root.left;
                }
                TNode minNode = FindMin(Root.Right);
                Root.Value = minNode.Value;
                Root.Right = Remove(Root.Right, minNode.Value);
            }
            return Root;
        }
        public TNode FindMin(TNode node)
        {
            while (node.left != null)
            {
                node = node.left;
            }
            return node;
        }
    }
}
