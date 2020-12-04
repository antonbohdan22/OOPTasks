using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperArray
{
    class Runner
    {
        static void Main(string[] args)
        {
            DeveloperArray<int> array = new DeveloperArray<int>();

            array.DevArray = new int[] { 1, 5, 2, 8, 9 };

            array.AddFirst(7);
            array.AddLast(7);
            array.InsertAt(7, 2);

            for(int i = 0; i < array.DevArray.Length; i++)
            {
                Console.Write(array.DevArray[i] + " ");
            }

            Console.WriteLine("\nContains {0} - {1}", 0, array.Contains(0));
            Console.WriteLine("Contains {0} - {1}", 8, array.Contains(8));

            Console.ReadKey();
        }
    }
}
