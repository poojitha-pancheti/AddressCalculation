using System;
using System.Collections.Generic;
using System.Text;

namespace AddressCalculationProject
{
   
    class SortedLinkedList
    {
        private Node start;
        public SortedLinkedList()
        {
            start = null;
        }
        public void InsertInOrder(int data)
        {
            Node p, temp;
            temp = new Node(data);
            if (start == null || data < start.info)
            {
                temp.link = start;
                start = temp;
                return;
            }
            p = start;
            while (p.link != null && p.link.info <= data)
                p = p.link;
            temp.link = p.link;
            p.link = temp;
        }
           
    }
}
