using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TestLinkedListNode<T>
    {
        public TestLinkedListNode<T> Next { get; set; }
        public T Value { get; set; }

        public TestLinkedListNode(T value)
        {
            Value = value;
        }
    }
}
