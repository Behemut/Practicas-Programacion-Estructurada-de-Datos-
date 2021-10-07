using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();
            Random rd = new Random();

            for (int i = 0; i < 10; i++)
            {
                myList.Insert(rd.Next(30));
            }

            myList.PrintList();
            Console.WriteLine("~~~~~~~~~~~~~");
            myList.SortL();
            myList.PrintList();
            Console.WriteLine("~~~~~~~~~~~~~");

            Console.ReadLine();
            
        }
    }
}
