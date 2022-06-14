using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.OOPS_5_MAY_2022
{class Department
    {
        int did;
        string dname;
        public Department(int did,string dname)
        {
            this.did = did;
            this.dname = dname;

        }
        public void show()
        {
            Console.WriteLine(did + " " + " "+dname);
        }
    }
    class EMPCONTAINMENTCONSTRUCTOR
    {
        int id;
        string name;
        Department dept;
        public EMPCONTAINMENTCONSTRUCTOR(int id, string name, Department dept)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
        }
        void display()
        {
            Console.WriteLine(id+" "+name+" ");
            dept.show();
        }
        static void Main(string[] args)
        {
            Department d = new Department(1, "SALES");
            EMPCONTAINMENTCONSTRUCTOR E = new EMPCONTAINMENTCONSTRUCTOR(101, "NIKHIL", d);
        }


    }
}
