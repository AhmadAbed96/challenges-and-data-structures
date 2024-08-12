using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class TNode
    {
        public TNode Right { get; set; }
        public TNode left { get; set; }
        public int Value { get; set; }
        public TNode(int value) 
        {
            Value = value;
            Right = null;
            left = null;
        }
    }
}
