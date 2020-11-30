using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class student : Person
    {
        public void Setname(string name)
        {
            this.name=name;
        }
        public void Setage(int age)
        {
            this.age = age;
        }
        public void Notice()
        {
            Console.WriteLine("Ten em la " + name + "\nAnh nam nay " + age + " tuoi");
        }
        public void Pos()
        {
            Console.WriteLine("Toi la sinh vien");
        }
    }
}
