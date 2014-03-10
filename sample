using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Random _random = new Random();

            // границы
            
            const int x = 5, y = 5;

            // массив для проверки нахождения елемента массива
            int[,] correctPosition = new int[x, y];

            int[,] field = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    field[i, j] = _random.Next(0, 2);
                   
                    Console.Write(" " + field[i, j].ToString() + " ");
                }

                Console.WriteLine("");
            }

            Console.ReadLine();
                                
             
            // создаем список Checked и Waiting

            ArrayList Checked = new ArrayList();
            ArrayList Waiting = new ArrayList();

            int a; int b; int c;
            Console.Write("Введите координату Х : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цвет (1 или 0): ");
            c = Convert.ToInt32(Console.ReadLine());

            if (field[a, b] == c)
            {
                Checked.Add(field[a, b]);
            }

            Console.Write(" " + Checked + " ");
        }


        public int GetElementAtIndex(int x, int y, int[,] array)
        {
            if ( x >= 0 && x < array.GetLength(0) && y >= 0 && y < array.GetLength(1))
            {
                return array[x, y];
            }

            else
            {

                return -1;

            }
        }

    }


    class Cell {

    public int x;
    public int y;
    private int color;

    public Cell (int xCoord, int yCoord, int Cellcolor) {

		    xCoord = x;
		    yCoord = x;
		    Cellcolor = color;

        }
    };
}

