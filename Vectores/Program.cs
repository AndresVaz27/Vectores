using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                List<int[]> arrays = new List<int[]>();
            int counter = 0;

                while (true)
                {
                    Console.Write("Enter the size of the array (0 to exit): ");
                    int size = int.Parse(Console.ReadLine());

                    if (size == 0)
                        break;

                    int[] dynamicArray = new int[size];

                    Console.WriteLine($"Enter {size} integers to populate the array:");
                    for (int i = 0; i < size; i++)
                    {
                        dynamicArray[i] = int.Parse(Console.ReadLine());
                    }

                    arrays.Add(dynamicArray);
                    Console.WriteLine("Array created and added to the list.\n");
                counter++;
                }

                Console.WriteLine("Arrays in the list: "+counter);
                foreach (int[] array in arrays) 
                {
                    Console.WriteLine("Array elements: ");
                    foreach (int element in array)
                    {
                        Console.WriteLine(element + " ");
                    }
                }
            Console.ReadLine();
        }
    }
}
