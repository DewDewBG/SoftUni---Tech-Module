﻿using System;

namespace _08._Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long id = long.Parse(Console.ReadLine());
            int employeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: " + name);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: " + id);
            Console.WriteLine("Unique Employee number: " + employeeNumber);
        }
    }
}
