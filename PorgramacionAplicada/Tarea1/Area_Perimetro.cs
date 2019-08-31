using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramacionAplicada.Tarea1
{
    class Area_Perimetro
    {
        public void area_perim()
        {
            float apotema, longitud, area, perimetro;
            int lados;
            int decision;

            Console.WriteLine("AREA(Presionar 1):::PERIMETRO(Presionar2)");
            decision = Convert.ToInt32(Console.ReadLine());

            if (decision == 1)
            {
                Console.WriteLine("INGRESE LA CANTIDAD DE LADOS DEL POLIGONO:");
                lados = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("INGRESE LA APOTEMA DEL POLIGOO:");
                apotema = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("INGRESE LA LONGITUD DE LOS LADOS DEL POLIGONO:");
                longitud = Convert.ToSingle(Console.ReadLine());

                area = lados * longitud * apotema / 2;

                Console.WriteLine("Area del poligono={0}", area);
            }
            else
            {
                Console.WriteLine("INGRESE LA CANTIDAD DE LADOS DEL POLIGONO:");
                lados = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("INGRESE EL DIAMETRO DE CADA LADO:");
                longitud = Convert.ToSingle(Console.ReadLine());

                perimetro = longitud * lados;


                Console.WriteLine("Perimetro del poligono={0}", perimetro);
            }

        }
    }
}
