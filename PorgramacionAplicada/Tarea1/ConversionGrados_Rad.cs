using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramacionAplicada.Tarea1
{
    class ConversionGrados_Rad
    {
        public void grados_radianes()
        {
            int grados;
            Double radianes, pi = 3.14;

            Console.WriteLine("INGRESE EL VALOR EN GRADOS:");
            grados = Convert.ToInt32(Console.ReadLine());

            radianes = grados * pi / 180;

            Console.WriteLine("CONVERCION DE GRADOS A RADIANES={0}", radianes);
        }
    }
}
