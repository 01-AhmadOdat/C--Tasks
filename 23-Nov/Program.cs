using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Nov
{
    internal class Program
    {
        //Task 1 >>>
        static void ahmad()
        {
            string[] inputs = Console.ReadLine().Split(',');
            int[] input = new int[10];
            double sum = 0;
            for (int x = 0; x <= 9; x++)
            {
                input[x] = Convert.ToInt16(inputs[x]);

            }
                for(int i=0; i<input.Length; i++) 
            {
                sum += input[i];
            }
                double avr = sum/ input.Length;
                Console.WriteLine("The sum of 10 numbers is : " + sum);
                Console.WriteLine("The average of 10 numbers is : " + avr);


        }  

        //Task 2 >>>
        static void ahmad2()
        {
            Console.Write("Write a number : ");
            int thenum = Convert.ToInt16(Console.ReadLine());
            int cnum = thenum * thenum * thenum;
            Console.WriteLine("The cube of the number is : " + cnum);

        }
        //Task 3 >>>
        static void ahmad3(int[] s) 
        {
            //int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            for (int y=0; y < s.Length ; y++) 
            {
                if (s[y] > 1950)
                {
                    Console.WriteLine(s[y]);
                }
            }

        }//Task 4 >>>
        static void ahmad4(int z)
        {
            Console.WriteLine("your age is : " + z);
           // int age = Convert.ToInt16(Console.ReadLine());
            int days = z * 365;
            Console.WriteLine("Input your age in days is : " + days);


        }
        //Task 5 >>>
        static void animals(int chicken, int cow, int cat)
        {
            int cowlegs = cow * 4;
            int chickenlegs = chicken * 2;
            int catlegs = cat * 4;
            Console.WriteLine("num of legs : " + (cowlegs + chickenlegs + catlegs));
        }

        //Task 6 >>>
        static void login(string uname , string pass)
        {
            string[] username = {"ahmad","ali","hosam","saleh","fares" };
            string[] password = { "123", "456", "789", "147", "258" };
            int f = 0;
            int u ;
            for( u=0 ; u < username.Length; u++) 
            {
                
                if (uname == username[u] && pass == password[u])
                {
                    Console.WriteLine("Passed");
                }
                else
                {
                    f++;
                }
                
            }
            if (u==f) { Console.WriteLine("Faild"); }
        }

        //Task 7 >>>
        static void power(int bas , int power)
        {
           int result = 1;
           for (int i = 1 ;i<=power ;i++)
            {
                result = result * bas ;
            }
            
            Console.WriteLine(result);
        }
        //Task 8 >>>
        static void leap(int year)
        {
            if (year >= 1900 && year <= 2024)
            { 
                
                if ((year % 4==0 && year % 100 != 0)||(year%400==0))
                {
                    Console.WriteLine( year + " This is a Leap Year");
                }
                else { Console.WriteLine(year + " This is a Normal Year"); }
            }
            else { Console.WriteLine("invalid input"); }
        }
        
        



        //Task 9 >>>
        static void primary(int pnum)
        {   if(pnum == 1 || pnum == 2)
            { Console.WriteLine("Primary"); }
            else if (pnum % 2 == 0 && pnum>2)
            { Console.WriteLine("not primary"); }
            if (pnum % 2 != 0)
            {
                int v=1 ;
                for(int e=3; e<pnum; e+=2)
                {
                    v += 2;
                    if(pnum%e==0)
                    {
                        Console.WriteLine("not primary");
                        break;
                    }
                }
                if (v == (pnum - 2))
                {
                    Console.WriteLine("Primary");
                }
                
            }
            
        }

        //Task 10 >>>

        static void wordscounter(string sentence)
        {
            int count = 1;
            for(int i=0; i <= sentence.Length-1; i++)
            {
                if (sentence[i]==' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count + " words");
        }

        static void Main(string[] args)
        {

            //ahmad();
            // ahmad2();
            // int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 , 2023 };
            // ahmad3(years);
            //ahmad4(25);
            //animals(1,1,1);
            //login("ahmad","456");
            // power(2,4);
            //primary(11);
            //leap(1500);
            wordscounter("ahmad khaled odat");
        }
    }
}
