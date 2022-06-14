using System;
using System.Collections.Generic;
using System.Text;
using ThirdWeekTQTrng.OOPS_5_MAY_2022;

namespace ThirdWeekTQTrng.OOPS_5_MAY_2022
{ class NIBOFPEN
    {
        string nibtype;
        public NIBOFPEN(string nibtype)
        { 
                this.nibtype = nibtype;
        }
        public void view()
        {
            Console.WriteLine("details of nib of pen:=="+nibtype);
        }
    }
    class PEN
    {
        string pencolour;
        string penbrandname;
        NIBOFPEN nibtype;
        public PEN (string pencolour, string penbrandname, NIBOFPEN nibtype)
       
            {  this.pencolour=pencolour;
            this.penbrandname=penbrandname;
            this.nibtype=nibtype;
            }


    public void show()
    {
        Console.WriteLine("PEN DETAILS:=="+pencolour + " " + penbrandname);
        nibtype.view();
    }
    }  
            

      

    
    class COMPLEXCONSTRUCTORCONTAINMENTBAG
    {

        string bagbrandname;
        string bagcolour;
        PEN pen;
    public COMPLEXCONSTRUCTORCONTAINMENTBAG(string bagbrandname, string bagcolour, PEN pen)
    {
            this.bagbrandname=bagbrandname;
            this.bagcolour=bagcolour;
            this.pen = pen;
    }
       public void dispaly()
    {
        Console.WriteLine("BAG DETRAILS:=="+bagbrandname + " " + bagcolour + " ");
        pen.show();
    }
    static void Main(string[]args)
    {
        NIBOFPEN n = new NIBOFPEN("METAL TYPE"); 
        PEN p = new PEN("Colour RED", "BRAND IS Cello", n);
        COMPLEXCONSTRUCTORCONTAINMENTBAG b = new COMPLEXCONSTRUCTORCONTAINMENTBAG("AMERICAN TOURISTER", "Colour Blue",p);
        b.dispaly();
    }
    }
}

