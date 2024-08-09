using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue1._stack.Min_Stack
{
    public class minStack : Stack
    {
        public int GetMin()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("An error occurred.");
            }
            var ListElement = new List<int>();
            Node node = top;
            while (node != null)
            {
                ListElement.Add(node.Data);
                node = node.Next;
            }
            return ListElement.Min();

        }
    }
}
