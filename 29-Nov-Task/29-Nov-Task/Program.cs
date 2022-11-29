using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Nov_Task
{
    class Employee
    {
        public string name { get; set; }
         public int birthday { get; set; }
         public int id { get; set; }

        public Employee(string name ,int birthday ,int id) 
        {
            this.name = name;   
            this.birthday=birthday;
            this.id = id;   
 
        }
        public virtual void  print ()
        {
            Console.WriteLine("Name :" + name + "\n" + "Birthday : " + birthday + "\nID NUM :  " + id);
        }
        public void age()
        {
            Console.Write("input the year of birthday date : ");
            int birth = Convert.ToInt32(Console.ReadLine());
            int age = (2022 - birth);
            Console.WriteLine("Your Age Is :  " + age);

        }

    }
    class Manager : Employee
    {

        // int birth = Convert.ToInt32(Console.ReadLine());
        // int age = (2022 - birth);
        public Manager(string name, int birthday, int id) : base(name, birthday, id)
        {
        }


        public override void print()//if i delete "override" what should happen?
        {
            Console.WriteLine("<<WITH OVERRIDE>>\n"+"Manager Name :" + name + "\n" + "Birthday : " + birthday + "\nID NUM :  " + id);
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Employee teacher = new Employee("Ali",1985,98555555);
            teacher.print();
            teacher.age();
            Manager ahmad = new Manager("Ahmad Odat", 1995, 995102255);
            ahmad.print();
            ahmad.age();
        }
    }
}
