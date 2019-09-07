using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramacionAplicada.Tarea2
{
    class PromedioJagged
    {
        public void promedio()
        {
          
            int  curso,estudiante=0,totalestudiantes=0,totalcalificaciones=0,promediocalificacion;
            int mayorcalificacion = 0,menorcalificacion=999999;
            


            Console.WriteLine("Ingrese la cantidad de cursos:");
            curso = Convert.ToInt32(Console.ReadLine());

            int[][] array = new int[curso][];

            for (int i = 0; i < curso; i++)
            {
                Console.Write("Ingrese la cantidad de estudiantes del curso {0}: ", i + 1);

                estudiante= Convert.ToInt32(Console.ReadLine());
                totalestudiantes += estudiante;

                array[i] = new int[estudiante];
            }



           


             for (int i = 0; i < curso; i++)
             {
                 for (int j = 0; j < array[i].GetLength(0); j++)
                 {

                    Console.WriteLine("Ingrese la calificacion del estudiante {0} del curso {1}", j + 1, i + 1);
                     array[i][j] = Convert.ToInt32(Console.ReadLine());

                    if (mayorcalificacion < array[i][j])
                    {
                        mayorcalificacion = array[i][j];
                    }

                    if (menorcalificacion> array[i][j])
                    {
                        menorcalificacion = array[i][j];
                    }
                    totalcalificaciones += array[i][j];
                 }
             }




            promediocalificacion = totalcalificaciones / totalestudiantes;

            Console.WriteLine("El promedio es={0}", promediocalificacion);
            Console.WriteLine("Mayor Calificacion={0}", mayorcalificacion);
            Console.WriteLine("Menor Calificacion={0}", menorcalificacion);





        }
    }
}
