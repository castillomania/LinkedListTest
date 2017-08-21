using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// The standard .net LinkedList class prevented connected nodes so I created my own linked list using code online from Pluralsight just to springboard the tests.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TestLinkedList<T>
    {
        public int Count { get; private set; }
        public TestLinkedListNode<T> Head { get; private set; }

        public TestLinkedListNode<T> Tail { get; private set; }

        public TestLinkedListNode<T> First { get { return Head; } }

        #region Add
        public void AddFirst(T value)
        {
            AddFirst(new TestLinkedListNode<T>(value));
        }

        public void AddFirst(TestLinkedListNode<T> node)
        {
            var temp = Head;

            Head = node;
            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new TestLinkedListNode<T>(value));
        }

        public void AddLast(TestLinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }

            Tail = node;

            Count++;
        }
        #endregion

        #region Remove
        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    var current = Head;
                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                    Tail = current;
                }
            }

            Count--;
        }
        #endregion
    }
}
