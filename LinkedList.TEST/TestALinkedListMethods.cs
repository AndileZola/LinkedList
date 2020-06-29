using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LinkedList.TEST
{
    public class TestALinkedListMethods
    {
        LinkedList linkedList = new LinkedList();

        [Theory]
        [InlineData(1, 1)]
        public void TestInsertingHeadNodeToALinkedList(int number, int expected)
        {
            linkedList.InsertNode(number);
            Assert.Equal(expected, linkedList.head.data);
        }

        [Theory]
        [InlineData(2, 2)]
        public void TestInsertingTailNodeToALinkedList(int number, int expected)
        {
            linkedList.InsertNode(1);
            linkedList.InsertNode(number);
            Assert.Equal(expected, linkedList.head.next.data);
        }

        [Theory]
        [InlineData(9, 9)]
        public void TestInsertingNodeAtSpecificPostion(int number, int expected)
        {
            linkedList.InsertNode(1);
            linkedList.InsertNode(2);
            linkedList.InsertNode(3);
            linkedList.InsertNode(4);
            linkedList.InsertAfter(linkedList.head, number);
            Assert.Equal(expected, linkedList.head.next.data);
        }

        [Theory]
        [InlineData(4, false)]
        public void TestDeletingNodeByData(int number, bool expected)
        {
            linkedList.InsertNode(1);
            linkedList.InsertNode(2);
            linkedList.InsertNode(3);
            linkedList.InsertNode(4);
            linkedList.DeleteNodeByData(number);
            var doesNoteExist = linkedList.DoesNodeExist(number);
            Assert.Equal(expected, doesNoteExist);
        }
        [Theory]
        [InlineData(4, true)]
        public void TestDoesNodeExistFunction(int number, bool expected)
        {
            linkedList.InsertNode(1);
            linkedList.InsertNode(2);
            linkedList.InsertNode(3);
            linkedList.InsertNode(4);
            var doesNoteExist = linkedList.DoesNodeExist(number);
            Assert.Equal(expected,doesNoteExist);
        }
    }
}
