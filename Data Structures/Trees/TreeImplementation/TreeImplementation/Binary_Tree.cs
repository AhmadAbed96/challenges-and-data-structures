using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class Binary_Tree : Binary_Search_Tree
    {
        private StringBuilder _output;
        public Binary_Tree(int data, StringBuilder output = null) : base(data)
        {
            _output = output;
        }

        public void Pre_Order(TNode node)
        {
            if (node == null) return;

            Print(node.Value, "->");
            Pre_Order(node.left);
            Pre_Order(node.Right);
        }

        public void In_Order(TNode node)
        {
            if (node == null) return;

            In_Order(node.left);
            Print(node.Value, "->");
            In_Order(node.Right);
        }

        public void Post_Order(TNode node)
        {
            if (node == null) return;

            Post_Order(node.left);
            Post_Order(node.Right);
            Print(node.Value, "->");
        }

        public void Print(int Value, string delimiter = "-->")
        {
            string output = $"{Value}{delimiter}";

            if (_output != null)
            {
                _output.Append(output);
            }
            else
            {
                Console.Write(output);
                Console.ResetColor();
            }
        }
        public void Mirror()
        {
            MirrorHelper(Root);
        }

        private void MirrorHelper(TNode node)
        {
            if (node == null)
            {
                return;
            }
            MirrorHelper(node.left);
            MirrorHelper(node.Right);
            TNode temp = node.left;
            node.left = node.Right;
            node.Right = temp;
        }

        public int? SecondMax(TNode node)
        {
            if (node == null) throw new Exception("the node is null");
            int? max = null;
            int? secondmax = null;
            TraverseTree(node, ref max, ref secondmax);
            if (secondmax == null)
            {
                throw new InvalidOperationException("Not Fount");
            }
            return secondmax;
        }
        public void TraverseTree(TNode node, ref int? max, ref int? secondmax)
        {
            if (node == null) return;

            TraverseTree(node.left, ref max, ref secondmax);
            if (max == null || node.Value > max)
            {
                secondmax = max;
                max = node.Value;
            }

            TraverseTree(node.Right, ref max, ref secondmax);
        }
    }
}
