using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedList
    {
        public Node head, tail;
        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void InsertNode(int n)
        {
            Node newNode = new Node();
            newNode.data = n;
            newNode.next = null;

            //If this is the first node to be added. It must be made a root node in the list
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                //The newly added node is added as the next node of the current tail node.
                tail.next = newNode;

            }

            /*The newly added node is always a tail.
             * If it is the only node in the list, it is both the head and tail.
             */
            tail = newNode;
        }

        public void InsertAfter(Node previousNode, int new_data)
        {
            //The provided node should never be null
            if (previousNode == null)
            { return; }
            else
            {
                Node newNode = new Node();
                newNode.data = new_data;
                newNode.next = previousNode.next;
                previousNode.next = newNode;
            }
        }

        public void DeleteNodeByData(int key)
        {
            //If the root node is null, it means there are no nodes to delete
            if (this.head != null)
            {
                Node headCopy = this.head;
                Node previousNode = null;

                //If deleting the root node
                if (headCopy?.data == key)
                {
                    //Assign linked list head to the current head next node
                    this.head = headCopy.next;
                }
                else
                {
                    //Shift the nodes backward to close the gap lef left by the deleted one
                    while (headCopy?.data != key)
                    {
                        previousNode = headCopy;

                        headCopy = headCopy.next;
                    }
                }

                if (previousNode != null)
                    previousNode.next = headCopy.next;
            }                      
        }

        public bool DoesNodeExist(int value)
        {
            Node selectedNode = head;
            while(selectedNode.next != null)
            {
                if (selectedNode.next.data == value)
                    return true;

                selectedNode = selectedNode.next;
            }
            return false;
        }

        public void PrintNodesList()
        {
            Node selectedNode = head;
            while(selectedNode.next != null)
            {
                Console.Write($"{selectedNode.data},");
                selectedNode = selectedNode.next;
            }
        }       
    }
}
