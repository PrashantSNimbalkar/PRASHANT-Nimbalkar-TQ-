using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class StudentInfo
    {
        int id;
        string name;
        int marks1;
        int marks2;
        int marks3;
        float percentage;
        public void accptdetails()
        {
            id = 1;
            name = "PRASHANT";
            marks1 = 90;
            marks2 = 85;
            marks3 = 95;

        }
        public float calpercentage()
        {
            percentage = (marks1 + marks2 + marks3) / 3;
            return percentage;
        }
        public void display()
        {
            Console.WriteLine(id + "  " + name + "  " + marks1 + "  " + marks2 + "  " + marks3 + "  " + percentage+"%");
        }
        
            static void Main(string[] args)
        {
            StudentInfo First = new StudentInfo();
            First.accptdetails();
            First.calpercentage();
            First.display();
        }
     }
}

