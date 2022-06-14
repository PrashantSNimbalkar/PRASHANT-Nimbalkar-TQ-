using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{class Engine
    {
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
    class CAR
    {
        int id;
        string cname;
        Engine eng;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Cname
        {
            get;
            set;
        }
        public Engine Eng
        {
            get { return eng; }
            set { eng = value; }
        }
        static void Main(string[]arg)
        {
            Engine e = new Engine();
            e.Type = "PETROL";
            CAR c = new CAR();
            c.Id = 4567;
            c.Cname = "AUDI";
            c.Eng = e;
            Console.WriteLine(c.Id + " " + c.Cname + " " + c.Eng.Type);
        }

    }
}
