using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            

            //question 2
            Console.Write("Please enter your name");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("please enter your second name");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(Q2(num1, num2));
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            //Qustion 5
            int counter = 1;
            do
            {
                Console.WriteLine($"8X{counter}={8 * counter}");
                counter++;
            } while (counter < 11);

            for(int i=1; i<11; i++)
            {
                Console.WriteLine($"8 X {i} = {Result(i)}");
            }

            //Qus 6
            //Console.Write("please enter the radius of circle: ");
            //int rad = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Perimeter = {perimeter(rad)}\nArea = {Area(rad)}");

            //qus 7
            int num1 = 10;
            int num2 = 20;
            int num3;
            Console.WriteLine($"num1: {num1}\nnum2: {num2}");

            num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine($"num1: {num1}\nnum2: {num2}");

        }

        static double Area(int radius)
        {
            return Math.PI * radius * radius;
        }

        static double perimeter(int radius)
        {
            return radius * Math.PI;
        }

        static double Result(double counter)
        {
            return counter * 8;
        }

        
        static double Q2(double num1, double num2)
        {
            return num1 + num2;
        }

        static double Q3(double num1, double num2)
        {
            return num1 / num2;
        }

        static string Q4(double num1, double num2)
        {
            return $"{num1} X {num2} = {num1 * num2}";
        }


    }
}   

