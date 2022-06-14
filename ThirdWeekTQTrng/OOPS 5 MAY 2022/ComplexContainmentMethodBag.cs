using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.OOPS_5_MAY_2022
{  class NIBOFPEN1
    {
        private string type;
        public string NIBTYPE
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }


    }
    class PEN1
    {
        private string pcolour;
        private string pname;
        NIBOFPEN1 nib;
        public string PCOLOUR
        {
            get
            {
                return pcolour;
            }
            set
            {
                pcolour = value;
            }
        }
        public string PNAME
        {
            get
            {
                return pname;
            }
            set
            {
                pname = value;
            }
        }
        public NIBOFPEN1 NIB
        {
            get
            {
                return nib;
            }
            set
            {
                nib = value;
            }

        }


    }
    class ComplexContainmentMethodBag
    {

        string bagbrandname;
        string bagcolour;
        PEN1 pen;
        public string BAGBARND
        {
            get
            {
                return bagbrandname;
            }
            set
            {
                bagbrandname = value;
            }
        }
        public string BAGCOLOUR
        {
            get
            {
                return bagcolour;
            }
            set
            {
                bagcolour = value;
            }
        }
        public PEN1 Pen
        {
            get
            {
                return pen;
            }
            set
            {
                this.pen = value;
            }

        }
        static void Main(string[] args)
        {
            NIBOFPEN1 n = new NIBOFPEN1();
            n.NIBTYPE = "METAL TYPE";
            PEN1 p = new PEN1();
            p.PCOLOUR = "BLUE COLOUR";
            p.PNAME = "CELLO BUTTERFLOW";
            p.NIB = n;
            ComplexContainmentMethodBag b = new ComplexContainmentMethodBag();
            b.BAGBARND = "AMERICAN TOURISTER";
            b.BAGCOLOUR = "RED COLOUR";
            b.Pen = p;
            Console.WriteLine("    THIS IS BAG PROPERTY  "+b.BAGBARND + "  " + b.BAGCOLOUR +   "   THIS IS PEN PROPERTY    "    + b.Pen.PCOLOUR + "    " + b.Pen.PNAME+"    THIS IS NIB PROPERTY    "+b.pen.NIB.NIBTYPE);




        }
    }
}
