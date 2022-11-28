using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Nov_Task
{
    class Car
    {
        int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        int price;
        public int Price
        {
            get { return price; }
            set { price = value; }

        }
        string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        int palletNum;
        public int PalletNum
        {
            get { return palletNum; }
            set { palletNum = value; }

        }
        int letter;
        public int Letter
        {
            get { return letter; }
            set { letter = value; }

        }
        string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        int rpm;
        public int Rpm
        {
            get { return Rpm; }
            set { Rpm = value; }
        }

        public Car() { }

        // Create a class constructor for the Car class
        public Car(int year, string type, int price, string model, int palletNum, string color ,int letter,int rpm)
        {
            this.year = year;
            this.type = type;
            this.price = price;
            this.model = model;
            this.palletNum = palletNum;
            this.color = color;
            this.letter = letter;
            this.rpm = rpm;
        }

        public void print()
        {
            Console.WriteLine("Production year : "+year +"\n"+ "Type : "  + type + "\n" + "Price : " + price + "\n" + "Model : " + model + "\n" + "Number Of Pallet : " + palletNum + "\n" + "Color : " + color );
        }

        public void fuel()
        {
            Console.WriteLine("Distance with full tank : "+letter *15 +" KM"+"\n");
        }

        public void RPM()
        {
            if (rpm > 0) { Console.WriteLine("Engine is ON "); }
            else 
                if (rpm == 0)
                 Console.WriteLine("Engine is OFF"); 
            
            
            else { Console.WriteLine("invalid input "); }
        }






    }// inheritance for the base class

    class BMW : Car
    {
        // Create a class constructor for the BMW class
        public BMW(int year, string type, int price, string model, int palletNum, string color , int letter) 
        {
            this.Year = year;
            this.Type = type;
            this.Price = price;
            this.Model = model;
            this.PalletNum = palletNum;
            this.Color = color;
            this.Letter= letter;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        { 
            Car mycar = new Car(2015,"Mitsubishi",10000, "Lanser", 55245, "black", 40,1500);
            BMW car1 = new BMW(2020, "BMW", 20000, "X5", 992555, "red" , 50);
            //Console.WriteLine(car1.Color);
            car1.Color = "white";//set the color
            car1.print();
            car1.fuel();
            mycar.print();
            mycar.RPM();

           // Console.WriteLine(car1.Letter);
            //car1.fuel();
        }

    }

}
