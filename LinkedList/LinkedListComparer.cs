using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    // I happened to create this class using a console app template. There's no particular reason other than random choice.
    public static class LinkedListComparer
    {
        /// <summary>
        /// I started with a brute force implementaton because it was the first solution that occurred to me, though I knew that it wouldn't be the most performant. TBH, was curious about what the performance difference would be between this implementation and the HashSet implementation below
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static bool AreListsConnected_BruteForce(TestLinkedList<int> list1, TestLinkedList<int> list2)
        {
            var node1 = list1.First;

            while (node1 != null)
            {
                var node2 = list2.First;

                while (node2 != null)
                {
                    if (node1 == node2) return true;

                    node2 = node2.Next;
                }

                node1 = node1.Next;
            }

            return false;
        }

        /// <summary>
        /// This is the HashSet implementation. 11ms for brute force vs. less than 1ms for the HashSet - definitely worth the time and effort to rethink the brute force implementation!
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static bool AreListsConnected_HashSet(TestLinkedList<int> list1, TestLinkedList<int> list2)
        {
            HashSet<int> list1Hash = new HashSet<int>();

            var node1 = list1.First;
            while (node1 != null)
            {
                list1Hash.Add(node1.Value);

                node1 = node1.Next;
            }

            var node2 = list2.First;
            while (node2 != null)
            {
                if (list1Hash.Contains(node2.Value)) return true;

                node2 = node2.Next;
            }

            return false;
        }
    }
}
