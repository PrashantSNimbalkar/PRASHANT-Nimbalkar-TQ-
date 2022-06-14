using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class EMPLOYEES
    {
        private int id;
        private string name;
        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        static void Main(string[] args)
        {
            EMPLOYEES e = new EMPLOYEES();
            e.Id = 100;
            Console.WriteLine(e.Id);
            e.Name = "PRASHANT";
            Console.WriteLine(e.Name);
        }
    }
}
