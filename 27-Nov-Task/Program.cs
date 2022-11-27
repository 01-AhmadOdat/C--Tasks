using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_nov_class_task
{
    class taxi
    {
        string model = "toyota";
        string color = "yellow";
        string driver = "ahmad";
        public void welcoming(string driver)
        {
            Console.WriteLine("welcome " + driver);
        }
        static void Main(string[] args)
        {
            taxi taxi1;
            taxi1 = new taxi();
                        taxi1.welcoming(taxi1.driver);
            Console.WriteLine("driver name: " + taxi1.driver);
            Console.WriteLine("color: " + taxi1.color);
            Console.WriteLine("model name: " + taxi1.model);


            taxi taxi2 = new taxi();
            taxi2.driver = "Amer";
            taxi2.color = "blue";
            taxi2.model = "BMW";
            Console.WriteLine("model name: " + taxi2.driver);
            Console.WriteLine("model name: " + taxi2.color);
            Console.WriteLine("model name: " + taxi2.model);
            taxi2.welcoming(taxi2.driver);


        }
    }
}
