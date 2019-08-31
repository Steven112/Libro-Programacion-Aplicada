using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramacionAplicada.Tarea1
{
    class Perimetro
    {
        public void perimetro()
        {
            int lados;
            float diametro, perimetro;

            Console.WriteLine("INGRESE LA CANTIDAD DE LADOS DEL POLIGONO:");
            lados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("INGRESE EL DIAMETRO DE CADA LADO:");
            diametro = Convert.ToSingle(Console.ReadLine());

            perimetro = diametro * lados;

            Console.WriteLine("Perimetro del poligono={0}", perimetro);




        }
    }
}
