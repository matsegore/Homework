using System;
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
            Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();

        }
        public static void Task1()
        {

        }

        public static void Task2()
        {

        }

        public static void Task3()
        {
            var v1 = "v";
            v1 = "Val";
            Console.WriteLine(v1);
        }

        public static void Task4()
        {
            Console.WriteLine("Введите значение стороны квадрата");
            int a = Convert.ToInt32(Console.ReadLine());
            int P = a * 4;
            Console.WriteLine($"Периметр равен: {P}");
        }

        public static void Task5()
        {
            const double  p = 3.14;
            Console.WriteLine("Введите радиус R1 (должен быть большечем R2)");
            double R1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус R2 (должен быть меньше R1)");
            double R2 = Convert.ToDouble(Console.ReadLine());

            double S1 = p * R1 * R1;
            double S2 = p * R2 * R2;
            double S3 = S1 - S2;
            Console.WriteLine($"S1: {S1}; S2: {S2}; S3: {S3}");

        }

        public static void Task6()
        {
            int a = 27;
            Console.WriteLine($"Numb: {a}");
            int b = a / 10;
            int c = a % 10;
            Console.WriteLine($"Left Numb: {b}");
            Console.WriteLine($"Right Numb: {c}");

        }

        public static void Task7()
        {
            int a = 12;
            int b = 10;
            long c = a + b;
            Console.WriteLine(c);
        }

        public static void Task8()
        {
            long a = 12;
            long b = 10;
            byte c = (byte)(a * b);
            Console.WriteLine(c);

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
