using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramacionAplicada.Tarea1
{
    class Conversion_Monedad
    {
        public void dolar_euros()
        {
            double dolar, euro, total;

            Console.WriteLine("INGRESE LA CANTIDAD EN DOLARES:");
            dolar = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("INGRESE EL PRECIO DEL DOLAR (CAMBIO DEL DIA):");
            euro = Convert.ToSingle(Console.ReadLine());

            total = dolar * euro;

            Console.WriteLine("El total en euros={0}", total);

        }
    }
}
