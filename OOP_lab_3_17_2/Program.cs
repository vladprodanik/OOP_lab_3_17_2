using System;
using System.IO;

namespace OOP_lab_3_17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fromFile = new StreamReader("f.txt");
            StreamWriter toFile = new StreamWriter("g.txt");

            string str = fromFile.ReadLine();

            string[] decimals = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach(string _decimal in  decimals)
            {
                int a = 1;

                if (Int32.TryParse(_decimal, out a))
                {
                    if (a % 2 == 0)
                    {
                        toFile.Write("{0} ", a);
                    }
                }
            }

            fromFile.Close();
            toFile.Close();
        }
    }
}
