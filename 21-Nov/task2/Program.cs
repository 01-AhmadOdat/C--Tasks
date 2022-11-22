using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("insert the first number");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("insert the second number");
            int y = Convert.ToInt16(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("The smaller number is: " + y);
            }
            else
            {
                if (y > x)
                {
                    Console.WriteLine("The smaller number is: " + x);    
                }
                else { Console.WriteLine("They are equal"); }
            }
            //TASK 2
            Console.WriteLine("write a number");
            int num = Convert.ToInt16(Console.ReadLine());
            if(num > 0)
            {
                Console.WriteLine("THE SIGN IS : +");

            }
            else
            {
                if(num < 0) {
                Console.WriteLine("tHE SIGN IS : -");}
                else { Console.WriteLine(0);
                }
            }

            //TASK 3
            
            Console.WriteLine("insert the first number");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("insert the second number");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("insert the third number");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a > b && a > c && b>c) 
            {
                Console.WriteLine(a+ " " + b +" " + c);
            }
            else {
                if (a > b && a > c && c > b) 
                {
                    Console.WriteLine(a + " " + c + " " + b);
                } 
                else if(b > a && b > c && a > c) 
                {
                    Console.WriteLine(b + " " + a + " " + c);
                }
                else if(b > a && b > c && c > a) 
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
                else if(c > a && c > b && a > b)
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
                else if(c > a && c > b && b > a)
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }
                    }
            //TASK 4
            Console.WriteLine("write the first number");
            int a1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("write the second number");
            int a2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("write the third number");
            int a3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("write the fourth number");
            int a4 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("write the fifth number");
            int a5 = Convert.ToInt16(Console.ReadLine());
            if (a1 > a2 && a1 > a3 && a1 > a4 && a1 > a5)
            { Console.WriteLine("The largest number is : " + a1); }
            else if(a2 > a1 && a2 > a3 && a2 > a4 && a2 > a5)
            { Console.WriteLine("The largest number is : " + a2); }
            else if(a3 > a2 && a3 > a1 && a3 > a4 && a3 > a5)
            { Console.WriteLine("The largest number is : " + a3); }
            else if(a4 > a1 && a4 > a2 && a4 > a3 && a4 > a5)
            { Console.WriteLine("The largest number is : " + a4); }
            else if(a5 > a2 && a5 > a3 && a5 > a4 && a5 > a1)
            { Console.WriteLine("The largest number is : " + a5); }
            

            //TASK 5
            Console.WriteLine("Input kilometers per hour: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            double distanceinmile = distance * .62137119;
            Console.WriteLine("Miles per hour = " + distanceinmile);
            

            //TASK 6
            Console.WriteLine("number of hours is : ");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("number of minutes is : ");
            double minutes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Total minutes are : " + ( hours*60 + minutes)+" minutes");

            


            //TASK 7
            Console.WriteLine("number of minutes is : ");
            int minutes = Convert.ToInt16(Console.ReadLine());
            int thehours = minutes / 60;
            int theminutes = minutes % 60;
            Console.WriteLine("THE TIME IS : " + (thehours)+"HOUR"+ "  &  "+(theminutes)+" "+"MINUTES");

            
            */

            //TASK 7
            string[] Names = { "Ahmad", "Othman", "Ali", "Khalid", "Samer","Saeed" };
            Console.WriteLine(Names[0].Substring(0, 3)+" "+ Names[1].Substring(0, 3)+" "+ Names[2].Substring(0, 3) + " " + Names[3].Substring(0, 3) + " " + Names[4].Substring(0, 3) + " " + Names[5].Substring(0, 3));
            






        }
    }
}
