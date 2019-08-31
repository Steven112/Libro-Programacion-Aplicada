using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramacionAplicada.Tarea1
{
    class TablaMultiplicar
    {
        public void tabla(){

            int n, i;
            Console.WriteLine(" Dijite el valor del numero");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1}={2}",n,i,(n*i));
            }

        }
    }
}
