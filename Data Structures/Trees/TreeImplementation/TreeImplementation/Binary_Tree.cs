using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class Binary_Tree 
    {
        public TNode Root { get; set; }

        public Binary_Tree(int RootVal)
        {
            Root = new TNode(RootVal);
        }
        private StringBuilder _output;

        public Binary_Tree(StringBuilder output = null)
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
    }
}
