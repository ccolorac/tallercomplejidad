using System;
using System.Collections.Generic;
using System.Text;

namespace TallerComplejidad
{
    class Punto10
    {
        static void Main(string[] args)
        {
            int ni, est;
            String nom;
            float pat, pagmant=50000;

            Console.WriteLine("Introduzca el número de la inscripción: ");
            ni = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca su nombre: ");
            nom = Console.ReadLine();
            
            Console.WriteLine("Introduzca su patrimonio: ");
            pat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca su estreato social: ");
            est = Convert.ToInt32(Console.ReadLine());

            if (pat>2000000)
            {      
                pagmant= pagmant+0.03*pat
            }



        }
    }
}
