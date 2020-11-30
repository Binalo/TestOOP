using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Person
{
    
    class StudentandTeacherTest
    {
        public static void InputFile()
        {
             string sentence;
            StreamWriter myfile = File.AppendText("D:/Code/Person/TextFile1.txt");
            do
            {
                Console.WriteLine("Them hinh : ");
                sentence = Console.ReadLine();
                if (sentence != "")
                {
                    myfile.WriteLine(sentence);
                }
            }
            while (sentence != ""
            );
            myfile.Close(); 
        }
        public static void OutputFile()
        {
            StreamReader myFile;
            try
            {
                myFile = File.OpenText("D:/Code/Person/TextFile1.txt");
                string line = "";
                do
                {
                    line = myFile.ReadLine();
                    if (line != null)
                        Console.WriteLine(line);
                }
                while (line != null);
            }
            catch (Exception)
            {
                Console.WriteLine("Xay ra Loi");
            }
            
        }
        public static void CountOfWords()
        {
            StreamReader myF=File.OpenText("D:/Code/Person/TextFile1.txt");
            string line;
            int n=0;
            do
            {
                line = myF.ReadLine();
                if (line != null)
                {
                    string[] word = line.Split(" ");
                    n += word.Length;
                }
            } while(line!=null);
            myF.Close();
            Console.WriteLine("Tong so tu co trong TextFile1.txt la: " + n);
        }
        static void Main()
        {
            //Person man = new Person();
            //man.greet();
            //Console.WriteLine("----------------------------------");
            //student myS = new student();
            //myS.Setage(30);
            //myS.Setname("Binh");
            //myS.Notice();
            //myS.Pos();
            //Console.WriteLine("----------------------------------");
            //Teacher her = new Teacher();
            //her.Setname("Uyen");
            //her.Teach();
            //her.Pos();
            //////////////////////////////////////////////--------------
            //string n="nguyen van dien" ;
            InputFile();
            Console.WriteLine("Done ");
            ///////////////////////////////////////////////------------
            Console.WriteLine("Doc File : ");
            OutputFile();
            //////////////////////////////////////////////////-------------
            Console.WriteLine("Dem so tu trong file -------------- ");
            CountOfWords();
            Console.ReadKey(); 
        }
    }
}
