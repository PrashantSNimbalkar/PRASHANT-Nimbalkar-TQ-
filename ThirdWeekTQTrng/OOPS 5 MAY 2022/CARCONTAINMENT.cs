using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.OOPS_5_MAY_2022
{ class Engine/*CONTANMENT BY USING COSTRUCTPRS PROGRAMME*/
    {
        string typeengine;
        public Engine(string typeengine)
        {
            this.typeengine = typeengine;
        }
        public void show()
        {
            Console.WriteLine(typeengine);
        }
    }
    class CARCONTAINMENT
    {
        int carid;
        string carname;
        int carprice;
        Engine engine;
        public CARCONTAINMENT(int carid, string carname, int carprice,Engine engine)
        {
            this.carid=carid;
            this.carname = carname;
            this.carprice = carprice;
            this.engine = engine;
        }
        void display()
        {
            Console.WriteLine(carid + " " + carname + " " + carprice + " ");
            engine.show();
        }
        static void Main(string[] args)
        {
            Engine e = new Engine("PETROL");
            CARCONTAINMENT c = new CARCONTAINMENT(100, "HONDA CITY", 1000000,e);
            c.display();
        }
    }
}