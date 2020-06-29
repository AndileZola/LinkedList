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
            linkedList.InsertNode(1);
            linkedList.InsertNode(2);
            linkedList.InsertNode(3);
            linkedList.InsertNode(4);
            linkedList.InsertNode(5);
            linkedList.InsertAfter(linkedList.head.next, 99);
            linkedList.DeleteNodeByData(5);
            linkedList.PrintNodesList();
        }
    }       
}
