using System;
using System.Collections.Generic;
namespace Collection
{
    // Online C# Editor for free
    // Write, Edit and Run your C# code using C# Online Compiler

    public class Student
    {
        public static void Main()
        {
            Dictionary<int, string> emp = new Dictionary<int, string>();
            emp.Add(1, "Name: sam ,Fee:5000");
            emp.Add(2, "Name: John,Fee:8000");
            emp.Add(3, "Name: Kiran,Fee:6000");
            foreach (var i in emp)
            {
                Console.WriteLine($"ID: {i.Key}, {i.Value}");
            }

        }
    }
}