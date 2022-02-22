using System;
using System.Collections.Generic;
using System.Text;

namespace TallerComplejidad
{
    class Punto8
    {
        static void Main(string[] args)
        {
            Boolean a=true, b=true, c=true, d=true, e=true ;
            int x;
            if (a && b)
            {
                x = 0;
            }
            if(a && !b && c)
            {
                x = 1;
            }
            if(a && !b && !c)
            {
                x = 3;
            }
            if(!a)
            {
                x = "falta revisar esta";
            }
            if(!a && d && e)
            {
                x = 5;
            }
            

        }

    }
}
