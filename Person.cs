using System;
using System.Collections.Generic;
using System.Text;
namespace Person
{
    class Person
    {
        //protected int age;
        //protected string name;
        public void greet()
        {
            Console.WriteLine("Hi em");
        }
        public int age { get; set; }
        public string name { get; set; }
    }
}