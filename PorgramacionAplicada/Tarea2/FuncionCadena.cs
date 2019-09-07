using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramacionAplicada.Tarea2
{
    class FuncionCadena
    {
        public void cadena()
        {
            int numero;
            Console.WriteLine("Ingese el numero");
            numero = Convert.ToInt32(Console.ReadLine());

            funcioncadenas(numero);


        }

        static void funcioncadenas(int numero)
        {
            string[] cadena = { "Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve" };

            Console.WriteLine("{0}", cadena[numero]);
        }
    }
}
