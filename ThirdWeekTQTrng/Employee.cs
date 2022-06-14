using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class Employee
    {
        int id;
        string name;
        int salary;
        public void acceptdetails()
        {
            id = 1;
            name = "AMIT";
            salary = 851467;
        }
        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
        static void Main(string[]args)
        {
            Employee e = new Employee();
            e.acceptdetails();
            e.Display();
        }
    }
}
