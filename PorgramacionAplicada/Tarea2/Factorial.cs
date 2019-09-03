using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramacionAplicada.Tarea2
{
    class Factorial
    {
        public void factor()
        {

            int n, i, factor = 1;
            Console.WriteLine(" Dijite el valor del numero");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = n; i >=1 ; i--)
            {

                factor = factor * i;



            }
            Console.WriteLine("Factorial de {0}={1}",n, factor);
        }
    }
}
