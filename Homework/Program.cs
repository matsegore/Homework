﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            Task9();

        }
        public static void Task1()
        {

        }

        public static void Task2()
        {

        }

        public static void Task3()
        {

        }

        public static void Task4()
        {

        }

        public static void Task5()
        {

        }

        public static void Task6()
        {

        }

        public static void Task7()
        {

        }

        public static void Task8()
        {

        }

        public static void Task9()
        {
            Console.WriteLine("Before swap");
            int a = 3;
            Console.WriteLine($"First number: {a}");
            int b = 5;
            Console.WriteLine($"First number: {b}");
            Console.WriteLine("After swap");
            /*int temp; //Первый способ с дополнительной переменной
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"First number: {a}");
            Console.WriteLine($"First number: {b}");*/
            a = b + a; // 3+5 =8
            b = a - b; // 8-5=3
            a = a - b; // 8-3=5 
            Console.WriteLine($"First number: {a}");
            Console.WriteLine($"First number: {b}");

        }
    }
}
