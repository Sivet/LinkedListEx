using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEx
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.AddInFront("Fish");
            l.AddInFront("Cat");
            l.AddInFront("Dog");

            l.Remove("Fish", l.firstElement);
            Console.ReadLine();
        }
        
    }
}
