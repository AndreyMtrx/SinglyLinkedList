
using SinglyLinkedList.Model;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(77);
            list.Add(4);
            list.Add(5);
            list.Add(90);
            list.Add(9);
            list.Remove(9);
            list.AddFirst(1000);
            list.AddAfter(9, 1111);
            list.AddAfter(1, 2222);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
