using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("inter your name");
            string name = Console.ReadLine();
            Console.WriteLine("your name is: " + name);
            int x = 10;
            Double y = 5.6D;
            String Myname = "Ahmad";
            char b = 'f';
            bool Mybool = true;
            const int Myconst = 50;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(b);
            Console.WriteLine(Mybool);
            Console.WriteLine(Myconst);
            Console.WriteLine(Myname + b);
            // Console.WriteLine(x + y + Myname + b + Mybool + Myconst);

            string[] cars = { "BMW", "TOYOTA", "HONDA", "KIA" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3]);

            string firstname = "Sami";
            string lastname = "Ali";
            int birthday = 1999;
            Console.WriteLine(firstname+" "+lastname+" "+" "+birthday);

            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(data[0] + " "+ data[1] + " " + data[2] + " " + data[3]+" " + data[4]+" " + data[5]+" " + data[6]+" " + data[7]+" " + data[8]);
            int[] sum = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(sum[1] + sum[2] + sum[3] + sum[4] + sum[5] + sum[6] + sum[7] + sum[8]);

        }
    }
}
