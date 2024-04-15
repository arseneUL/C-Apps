using System;
using System.Data;
using System.Diagnostics;
using System.Timers;
using System.Threading;

namespace LoadingConsoleUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Loading(10,500);
            Loading(500);
            Console.ReadLine();
        }

        /*public static void Loading(int n, int ms)
        {
            int count = 0;
            int count2 = 0;
            while (count < n)
            {
                if (count == 0)
                {
                    Console.Write(".");
                    count++;
                }
                else
                {
                    Console.Clear();
                    int seconds = 0;
                    while (seconds < 1)
                    {
                        //Console.WriteLine($"Elapsed seconds: {seconds}");
                        seconds++;
                        Thread.Sleep(ms); // Sleep for 1 second (1000 milliseconds)
                    }
                    Console.Write(new String ('.',count));
                    count++;
                }
            }

            Console.WriteLine("Boom");
            Console.ReadLine();
        }*/
        public static void Loading(int n, int ms)
        {
            int count = 0;
            int count2 = 0;
            while (count < n)
            {
                if (count == 0)
                {
                    Console.Write(".");
                    count++;
                }
                else
                {
                    Console.Clear();
                    while (count2 < count)
                    {
                        int seconds = 0;
                        while (seconds < 1)
                        {
                            //Console.WriteLine($"Elapsed seconds: {seconds}");
                            seconds++;
                            Thread.Sleep(ms); // Sleep for 1 second (1000 milliseconds)
                        }

                        
                        Console.Write(".", count);
                        count2++;
                    }

                    count++;
                    count2 = 0;
                }
            }
            Console.WriteLine( "\n" + "Boom");
            Console.ReadLine();
        }

        public static void Loading(int ms)
        {
            int count = 0;
            int count2 = 0;
            while (true)
            {
                if (count == 0)
                {
                    Console.Write(".");
                    count++;
                }
                else
                {
                    Console.Clear();
                    while (count2 < 5)
                    {
                        int seconds = 0;
                        while (seconds < 1)
                        {
                            //Console.WriteLine($"Elapsed seconds: {seconds}");
                            seconds++;
                            Thread.Sleep(ms); // Sleep for 1 second (1000 milliseconds)
                        }

                        
                        Console.Write(".", count);
                        count2++;
                    }
                    Thread.Sleep(500);
                    count++;
                    count2 = 0;
                }
            }
        }
    }
    
    
}