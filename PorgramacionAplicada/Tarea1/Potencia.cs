using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramacionAplicada.Tarea1
{
    class Potencia
    {
        public void elevar() {
            double num, potencia, total;

            Console.WriteLine(" Dijite el valor del numero a elevar");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Dijite el valor de la potencia");
            potencia = Convert.ToDouble(Console.ReadLine());

            total = Math.Pow(num, potencia);
            Console.WriteLine("Potencia de {0} elevado a {1}={2}", num, potencia, total);
        }
    }
}
