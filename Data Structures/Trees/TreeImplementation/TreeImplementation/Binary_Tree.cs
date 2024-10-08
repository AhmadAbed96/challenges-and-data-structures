﻿using System;
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

        public List<int> LargestValueEachLevel()
        {
            List<int> largestValues = new List<int>();
            if (Root == null) return largestValues;

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxAtLevel = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    var currentNode = queue.Dequeue();
                    if (currentNode.Value > maxAtLevel)
                    {
                        maxAtLevel = currentNode.Value;
                    }

                    if (currentNode.left != null) queue.Enqueue(currentNode.left);
                    if (currentNode.Right != null) queue.Enqueue(currentNode.Right);
                }

                largestValues.Add(maxAtLevel);
            }

            return largestValues;
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

        public void PrintRightView()
        {
            List<int> rightViewNodes = new List<int>();
            RightViewHelper(Root, 0, rightViewNodes);

            Console.WriteLine(string.Join(" ", rightViewNodes));
        }

        private void RightViewHelper(TNode node, int level,
            List<int> rightViewNodes)
        {
            if (node == null)
                return;
            if (level == rightViewNodes.Count)
                rightViewNodes.Add(node.Value);
            RightViewHelper(node.Right, level + 1, rightViewNodes);
            RightViewHelper(node.left, level + 1, rightViewNodes);
        }
    }
}
