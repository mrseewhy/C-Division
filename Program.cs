﻿using System;

namespace division
{
    class Program
    {
        static void Main(string[] args)
        {
            //First varibale
            int no1 = 0;
            //second variable
            int no2 = 0;
            //result as a variable
            int result = 0;
            //Text to get the input
            Console.Write("Enter A Number: ");
            //adding the input to the first variable and converting it to a Number
            no1 = int.Parse(Console.ReadLine());
            //Text to get the input
            Console.Write("Enter Another Number: ");
            //adding the input to the second variable and converting it to a Number
            no2 = int.Parse(Console.ReadLine());
            //Result as an division
            result = no1 / no2;
            //Output text
            Console.WriteLine("Division: " + result);
        }
    }
}
