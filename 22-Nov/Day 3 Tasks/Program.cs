using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 ={"Str", "alex", "moh"};
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };
            //Console.WriteLine(ARR[] + arr2[] + arr3[]);
            foreach (int i in ARR) { Console.WriteLine(i); } 
            foreach (string a in arr2) { Console.WriteLine(a); }
            foreach (string b in arr3) { Console.WriteLine(b); }
            
            //Task2>>>
             String[] fruits = { "Tomato", "Banana", "Watermelon" , "watermelon"};
            Console.WriteLine("The index is :" + Array.IndexOf(fruits , "Banana"));
            Console.WriteLine("The index is : " + Array.IndexOf(fruits, "watermelon"));



            //Task3>>>
            
            string[] foods = { "masaf", "shawarma", "pizza", "kafta" };
            string[] sports = { "basketball", "swimming", "football" };
            

            string[] movies = { "breaking bad", "artorol", "othman" };

            for(int f=0 ; f<foods.Length ; f++)
            {
                Console.WriteLine(foods[f]);
            }
            foreach (string s in sports) { Console.WriteLine(s); };
            foreach ( string m in movies) { Console.WriteLine(m); };
            
            //Task4>>>
            //int input = Convert.ToInt32(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(',');
            int sum = 0;
            for(int i=0; i<inputs.Length; i++) 
            { sum += Convert.ToInt32(inputs[i]);
            }
            Console.WriteLine(sum);
            
            //Task5>>>
            int sumodd = 0;
            for(int o = 0; o <=100; o++)
            {
                if (o % 2 == 1)
                {   
                    
                    Console.Write(" "+o);
                    sumodd += o;
                }
            }
            Console.WriteLine("\n"+sumodd);

            

            //Task6>>>
           // char v = '*';
            for(int s=1; s<=4; s++)
            {
                //int t = 4 - s;
                for (int space =4-s; space > 0; space--)
                { Console.Write(" "); }

                
                for(int x =1 ; x<=s ;x++)
                {
                    
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //Task7>>>
            int w = 1;
            for (int u = 1; u <= 4; u++)
            {
                
                for (int space = 4 - u; space > 0; space--)
                { Console.Write(" "); }


                for (int x = 1; x <= u; x++)
                {

                    Console.Write((w++) + " ");
                }
                Console.WriteLine();
            }

















        }
    }
}
