using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11exe
{
    class Program
    {
        static void Main(string[] args)
        {


            String[] name = new string[10];
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddFirst(100);
            myList.AddFirst(0);
            myList.AddLast(50);
            LinkedListNode<int> midNode = myList.First.Next;
            LinkedListNode<int> second = myList.First.Next.Next;
            myList.AddBefore(midNode, 60);
            myList.AddBefore(second, 165);

            System.Collections.IEnumerator myEnumerator = myList.GetEnumerator();
            int total = 0;
            while (myEnumerator.MoveNext() == true)
            {
                total += (int)myEnumerator.Current;
            }

            total = 0;
            foreach (int x in myList)
            {
                total += x;
            }

            int lenght = (int)myList.LongCount();
            double avg = total / lenght;


            Console.WriteLine(avg);
            Console.ReadLine();
        }
    }
}
