using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Method_GetElementAtIndex
{
    class Program
    {
        private static void Main(string[] args)
        {
            int horizontalLength = 10;
            int verticalLength = 5;

            int[,] array = new int[horizontalLength, verticalLength];

            Console.Write("Введите X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (GetElementAtIndex(x, y, array) != -1)
            {
                Console.WriteLine("Такой элемент существует!");
            }
            else
            {
                Console.WriteLine("Такой элемент не существует!");
            }
        }

        public static int GetElementAtIndex(int x, int y, int[,] array)
        {
            if (x >= 0 && x < array.GetLength(0) && y >= 0 && y < array.GetLength(1))
            {
                return array[x, y];
            }
            else
            {
                return -1;
            }
        }
    }
}
