using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normal_1_28
{
    class Program
    {

        class Prog
        {
            static void Main(string[] args)
            {
               
                Console.WriteLine("Введите размер массива :");
                int arraySize = Int32.Parse(Console.ReadLine());
                int[] arrays = new int [arraySize];
                int arraysSum = 0;

                for (int i = 0; i < arrays.Length; i++)
                {
                    Console.Write("Введите {0}-е число :", i+1);
                    arrays[i] = Int32.Parse(Console.ReadLine());
                    arraysSum += arrays[i];
                    
                }
                Console.WriteLine("Cреднее арефмитическое: {0}", arraysSum  / arrays.Length);
                Console.ReadLine();
            }
        }
    }
}
