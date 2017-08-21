using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;

namespace LinkedListTest
{
    /// <summary>
    /// This class uses the TestLinkedList and TestLinkedListNode classes I cribbed because it wouldn't allow connecting nodes to two separate linked lists.
    /// </summary>
    [TestClass]
    public class LinkedListComparerTest
    {
        /// <summary>
        /// Tests two unconnected linked lists using the brute force implementation. Should return false, indicating that they aren't connected.
        /// </summary>
        [TestMethod]
        public void TestForUnconnectedLists_BruteForce()
        {
            var list1 = new TestLinkedList<int>();
            var list2 = new TestLinkedList<int>();

            var n1 = new TestLinkedListNode<int>(1);
            var n2 = new TestLinkedListNode<int>(2);
            var n3 = new TestLinkedListNode<int>(3);
            var n4 = new TestLinkedListNode<int>(4);
            var n5 = new TestLinkedListNode<int>(5);
            var n6 = new TestLinkedListNode<int>(6);
            var n7 = new TestLinkedListNode<int>(7);
            var n8 = new TestLinkedListNode<int>(8);
            var n9 = new TestLinkedListNode<int>(9);

            list1.AddLast(n3);
            list1.AddLast(n6);
            list1.AddLast(n7);
            list1.AddLast(n9);

            list2.AddLast(n1);
            list2.AddLast(n2);
            list2.AddLast(n5);
            list2.AddLast(n8);

            var result = LinkedListComparer.AreListsConnected_BruteForce(list1, list2);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// Tests two connected linked lists using the brute force implementation. Should result in true, indicating that they are connected.
        /// </summary>
        [TestMethod]
        public void TestForConnectedLists_BruteForce()
        {
            var list1 = new TestLinkedList<int>();
            var list2 = new TestLinkedList<int>();

            var n0 = new TestLinkedListNode<int>(0);
            var n1 = new TestLinkedListNode<int>(1);
            var n2 = new TestLinkedListNode<int>(2);
            var n3 = new TestLinkedListNode<int>(3);
            var n4 = new TestLinkedListNode<int>(4);
            var n5 = new TestLinkedListNode<int>(5);
            var n10 = new TestLinkedListNode<int>(10);
            var n11 = new TestLinkedListNode<int>(11);
            var n12 = new TestLinkedListNode<int>(12);

            list1.AddLast(n0);
            list1.AddLast(n1);
            list1.AddLast(n2);
            list1.AddLast(n3);
            list1.AddLast(n4);
            list1.AddLast(n5);

            list2.AddLast(n10);
            list2.AddLast(n11);
            list2.AddLast(n12);
            list2.AddLast(n3);

            var result = LinkedListComparer.AreListsConnected_BruteForce(list1, list2);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// Tests two unconnected linked lists using the hash set implementation. Should return false, indicating that they aren't connected.
        /// </summary>
        [TestMethod]
        public void TestForUnconnectedLists_HashSet()
        {
            var list1 = new TestLinkedList<int>();
            var list2 = new TestLinkedList<int>();

            var n1 = new TestLinkedListNode<int>(1);
            var n2 = new TestLinkedListNode<int>(2);
            var n3 = new TestLinkedListNode<int>(3);
            var n4 = new TestLinkedListNode<int>(4);
            var n5 = new TestLinkedListNode<int>(5);
            var n6 = new TestLinkedListNode<int>(6);
            var n7 = new TestLinkedListNode<int>(7);
            var n8 = new TestLinkedListNode<int>(8);
            var n9 = new TestLinkedListNode<int>(9);

            list1.AddLast(n3);
            list1.AddLast(n6);
            list1.AddLast(n7);
            list1.AddLast(n9);

            list2.AddLast(n1);
            list2.AddLast(n2);
            list2.AddLast(n5);
            list2.AddLast(n8);

            var result = LinkedListComparer.AreListsConnected_HashSet(list1, list2);

            Assert.IsFalse(result);
        }

        /// <summary>
        /// Tests two connected linked lists using the hash set implementation. Should return true, indicating that they are connected.
        /// </summary>
        [TestMethod]
        public void TestForConnectedLists_HashSet()
        {
            var list1 = new TestLinkedList<int>();
            var list2 = new TestLinkedList<int>();

            var n0 = new TestLinkedListNode<int>(0);
            var n1 = new TestLinkedListNode<int>(1);
            var n2 = new TestLinkedListNode<int>(2);
            var n3 = new TestLinkedListNode<int>(3);
            var n4 = new TestLinkedListNode<int>(4);
            var n5 = new TestLinkedListNode<int>(5);
            var n10 = new TestLinkedListNode<int>(10);
            var n11 = new TestLinkedListNode<int>(11);
            var n12 = new TestLinkedListNode<int>(12);

            list1.AddLast(n0);
            list1.AddLast(n1);
            list1.AddLast(n2);
            list1.AddLast(n3);
            list1.AddLast(n4);
            list1.AddLast(n5);

            list2.AddLast(n10);
            list2.AddLast(n11);
            list2.AddLast(n12);
            list2.AddLast(n3);

            var result = LinkedListComparer.AreListsConnected_HashSet(list1, list2);

            Assert.IsTrue(result);
        }
    }
}
