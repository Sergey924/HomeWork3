
using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Задание 1");
        
        Console.WriteLine();

        Console.WriteLine("Введите кол-во строк массива");
        int.TryParse(Console.ReadLine(), out int Rows);

        Console.WriteLine("Введите кол-во стобцов массива");
        int.TryParse(Console.ReadLine(), out int Columns);

        int[,] Array1 = new int[Rows, Columns];
        int Max = Array1[0, 0];
        int Min = Array1[0, 0];
        int Middle = 0;

        Random random = new Random();
        for (int i = 0; i < Array1.GetLength(0); i++)
        {
            for (int j = 0; j < Array1.GetLength(1); j++)
            {
                Array1[i, j] = random.Next(1, 26);           

                if (Array1[i,j] < Min)
                {
                    Min = Array1[i, j];
                }

                else
                {
                    Min = Array1[0, 0];
                }
            }
        }

        for (int i = 0; i < Array1.GetLength(0); i++)
        {
            for (int j = 0; j < Array1.GetLength(1); j++)
            {
                Console.Write(Array1[i, j] + "\t");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < Array1.GetLength(0); i++)
        {
            for (int j = 0; j < Array1.GetLength(1); j++)
            {
                if (Max < Array1[i,j])
                {
                    Max = Array1[i, j];
                }            
            }
        }

        for (int i = 0; i < Array1.GetLength(0); i++)
        {
            for (int j = 0; j < Array1.GetLength(1); j++)
            {
                if ( Array1[i, j] < Min)
                {
                    Min = Array1[i, j];
                }
            }
        }

        for (int i = 0; i < Array1.GetLength(0); i++)
        {
            for (int j = 0; j < Array1.GetLength(1); j++)
            {
                Middle += Array1[i, j];
            }
        }
        Middle /= Rows * Columns;

        Console.WriteLine("Max:" + Max);
        Console.WriteLine("Min:" + Min);
        Console.WriteLine("Mid:" + Middle);

        Console.WriteLine();



        Console.WriteLine("Задание 2");

        Console.WriteLine();

        Console.WriteLine("Часть 1");

        Console.WriteLine();

        int[,] Array2 = new int[5, 5];
        int x = 1;

        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                Array2[i, j] = (i + j) % 2 == 0 ? i + x : j + 1;
                x++;
            }
        }

        int y = -1;

        for (int i = 1; i < 2; i++)
        {
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                Array2[i, j] = (i + j) % 2 == 0 ? i + y : j;
                y++;               
            }
            Array2[1, 4] = 0;
        }

          Array2[2, 2] = 1;

        int c = -3;

        for (int i = 3; i < 4; i++)
        {
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                Array2[i, j] = (i + j) % 2 == 0 ? i + c : j;
                c++;
            }
            Array2[3, 4] = 0;
        }

        int z = -3;

        for (int i = 4; i < 5; i++)
        {
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                Array2[i, j] = (i + j) % 2 == 0 ? i + z : j + 1;
                z++;
            }
        }

        for (int i = 0; i < Array2.GetLength(0); i++)
        {
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                Console.Write(Array2[i, j] + "\t");
            }
            Console.WriteLine();
        }
       Console.WriteLine();




        Console.WriteLine("Часть 2");

        Console.WriteLine();

        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                Array2[i, j] = (i + j) % 2 == 0 ? 1  :  1;                
            }
        }

        for (int i = 1; i < 2; i++)
        {
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                Array2[i, j] = (i + j) % 2 == 0 ? 0  : i;

            }
        }
        Array2[1, 2] = 0;

        for (int i = 2; i < 3; i++)
        {
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                Array2[i, j] = (i + j) % 2 == 0 ? i - 1 : 0;
            }
        }
        Array2[2, 2] = 0;

        for (int i = 3; i < 4; i++)
        {
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                Array2[i, j] = (i + j) % 2 == 0 ? 0 : i - 2;
            }
        }
        Array2[3, 2] = 0;

        for (int i = 4; i < 5; i++)
        {
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                Array2[i, j] = (i + j) % 2 == 0 ? 1 : 1;
            }
        }


        for (int i = 0; i < Array2.GetLength(0); i++)
        {
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                Console.Write(Array2[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Часть 3");

        Console.WriteLine();

        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                Array2[i, j] = (i + j) % 2 == 0 ? 1 : 0;
            }
        }
        Array2[0, 2] = 0;

        for (int i = 1; i < 2; i++)
        {
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                Array2[i, j] = (i + j) % 2 == 0 ? i : 0;

            }
        }

        Array2[2, 2] = 1;

        for (int i = 3; i < 4; i++)
        {
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                Array2[i, j] = (i + j) % 2 == 0 ? i - 2 : 0;

            }
        }

        for (int i = 4; i < 5; i++)
        {
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                Array2[i, j] = (i + j) % 2 == 0 ? i - 3 : 0;
            }
        }
        Array2[4, 2] = 0;

        for (int i = 0; i < Array2.GetLength(0); i++)
        {
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                Console.Write(Array2[i, j] + "\t");
            }
            Console.WriteLine();
        }

      
    }


}
                 

