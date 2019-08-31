using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramacionAplicada.Tarea1
{
    class PareImpares
    {
        public void par_impar()
        {
            int entero;


            Console.WriteLine("INGRESE EL ENTERO A EVALUAR:");
            entero = Convert.ToInt32(Console.ReadLine());

            if ((entero % 2) == 0)
            {
                Console.WriteLine("El eentero es par");
            }
            else
            {
                Console.WriteLine("El eentero es impar");
            }


        }
    }
}
