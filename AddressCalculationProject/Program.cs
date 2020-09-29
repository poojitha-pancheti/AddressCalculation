using System;
using System.Xml;

namespace AddressCalculationProject
{
    class Program
    {
        public static void Sort(int[] a,int n)
        {
            int i, j, x;
            SortedLinkedList[] list = new SortedLinkedList[6];
            for (i = 0; i < 6; i++)
                List[i] = new SortedLinkedList();
            int large = 0;
            for (i = 0; i < n; i++)
            {
                if (a[i] > large)
                    large = a[i];
            }
            for (i = 0; i < n; i++)
            {
                x = Hash(a[i], large);
                list[x].InsertInOrder(a[i]);
            }
            Node p;
            i = 0;
            for (j = 0; j <= 5; j++)
            {
                p = List[j].GetStart();
                while (p != null)
                {
                    a[i++] = p.info;
                    p = p.link;
                }
            }
        }
        public static int Hash(int x,int large)
        {
            float temp;
            temp = (float)x / large;
            return (int)(temp * 5);
        }
        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[20];
            Console.WriteLine("Enter the number of elements:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("Enter element" + (i + 1) + ":");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sort(a, n);
            Console.WriteLine("Sorted array is:");
            for (i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
    }
}
