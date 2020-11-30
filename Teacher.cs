using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Teacher : Person
    {
        public void Setname(string name)
        {
            this.name = name;
        }
        public void Teach()
        {
            Console.WriteLine("Toi ten la "+this.name+" :))");
        }
        public void Pos()
        {
            Console.WriteLine("Toi la giao vien");
        }
    }
}
