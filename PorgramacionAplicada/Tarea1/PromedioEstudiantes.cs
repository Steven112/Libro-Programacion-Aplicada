using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramacionAplicada.Tarea1
{
    class PromedioEstudiantes
    {
        public void promedio()
        {

            int num, i, edad, mayor = 0, menor = 999999999, total_edades = 0, promedio; ;
            Console.WriteLine(" Dijite el numero de estudiantes");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < num; i++)
            {
                Console.WriteLine(" Dijite la edad del estudiante {0}",i+1);
                edad = Convert.ToInt32(Console.ReadLine());
                total_edades = total_edades + edad;

                if (edad > mayor)
                {
                    mayor = edad;
                }

                if (edad < menor)
                {
                    menor = edad;
                }
            }

            promedio = total_edades / num;

            Console.WriteLine(" El promedio de edad= {0}",promedio);

            Console.WriteLine(" La edad mayor es= {0}", mayor);
            Console.WriteLine(" La edad menor es= {0}", menor); 





        }
    }
}
