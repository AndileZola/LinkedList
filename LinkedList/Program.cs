using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            //Insert nodes
            linkedList.InsertNode(1);
            linkedList.InsertNode(2);
            linkedList.InsertNode(3);
            linkedList.InsertNode(4);
            linkedList.InsertNode(5);

            //Insert Node at a specific postion
            linkedList.InsertAfter(linkedList.head.next, 99);

            //Delete a specific node
            linkedList.DeleteNodeByData(5);

            //Print all linkedlist nodes
            linkedList.PrintNodesList();
        }
    }       
}
