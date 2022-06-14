using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.OOPS_5_MAY_2022
{
    class STUDENTDATAGETSET
    {
        private int id;
        private string name;
        private double percentage;
        
        public int ID
        {
            get { return id; }
            set { this.id = value; }
        }
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }                                                                                                                                                                       
        public double PERCENTAGE
        {
            get { return percentage; }
            set { percentage = value; }
        }
        static void Main(string[]args)
        {
            STUDENTDATAGETSET e = new STUDENTDATAGETSET();
            e.ID = 1;
            Console.WriteLine(e.ID);
            e.NAME = "PRASHANT";
            Console.WriteLine(e.NAME);
            e.PERCENTAGE = 93.60;
            Console.WriteLine(e.PERCENTAGE);
        }
    }
}
