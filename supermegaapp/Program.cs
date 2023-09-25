using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermegaapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[6, 6];

            Rand();

            A();
            B();
            C();
            D();
            E();
            F();
            G();
            H();
            I();
            J();

            void A()
            {
                int max = int.MinValue;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {

                        if (max < array[i, j] && j >= i)
                            max = array[i, j];

                    }
                }

                Console.WriteLine("а: " + max);
            }

            void B()
            {
                int max = int.MinValue;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {

                        if (max < array[i, j] && j <= i)
                            max = array[i, j];
                    }
                }
                Console.WriteLine("b: " + max);
            }

            void C()
            {
                int max = int.MinValue;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {

                        if (max < array[i, j] && j >= i && j <= array.GetLength(0) - i - 1)
                            max = array[i, j];
                    }
                }
                Console.WriteLine("c: " + max);
            }

            void D()
            {
                int max = int.MinValue;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {

                        if (max < array[i, j] && j <= i && j >= array.GetLength(0) - i - 1)
                            max = array[i, j];
                    }
                }
                Console.WriteLine("d: " + max);
            }

            void E()
            {
                int max = int.MinValue;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {

                        if (max < array[i, j] && j <= i && j >= array.GetLength(0) - i - 1 ||
                            j >= i && j <= array.GetLength(0) - i - 1 && max < array[i, j])
                            max = array[i, j];
                    }
                }
                Console.WriteLine("e: " + max);
            }

            void F()
            {
                int max = int.MinValue;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {

                        if (max < array[i, j] && j >= i && j >= array.GetLength(0) - i - 1 ||
                            j <= i && j <= array.GetLength(0) - i - 1 && max < array[i, j])
                            max = array[i, j];
                    }
                }
                Console.WriteLine("f: " + max);
            }

            void G()
            {
                int max = int.MinValue;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {

                        if (max < array[i, j] && j <= i && j <= array.GetLength(0) - i - 1)
                            max = array[i, j];
                    }
                }
                Console.WriteLine("g: " + max);
            }

            void H()
            {
                int max = int.MinValue;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {

                        if (max < array[i, j] && j >= i && j >= array.GetLength(0) - i - 1)
                            max = array[i, j];
                    }
                }
                Console.WriteLine("h: " + max);
            }

            void I()
            {
                int max = int.MinValue;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {

                        if (max < array[i, j] && j <= array.GetLength(0) - i - 1)
                            max = array[i, j];
                    }
                }
                Console.WriteLine("i: " + max);
            }

            void J()
            {
                int max = int.MinValue;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {

                        if (max < array[i, j] && j >= array.GetLength(0) - i - 1)
                            max = array[i, j];
                    }
                }
                Console.WriteLine("j: " + max);
            }



            void Rand()
            {
                Random rand = new Random();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = rand.Next(0, 99);
                    }
                }
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}
