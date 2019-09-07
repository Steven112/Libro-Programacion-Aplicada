using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramacionAplicada.Tarea2
{
    class PromedioJaggedFunciones
    {
        int totalestudiantes = 0;
        int mayorcalificacion = 0, menorcalificacion = 999999;
        int totalcalificaciones = 0;
        public void promedio()
        {

            int curso,  promediocalificacion;
            



            Console.WriteLine("Ingrese la cantidad de cursos:");
            curso = Convert.ToInt32(Console.ReadLine());

            int[][] array = new int[curso][];


            cantidadestudiante(curso, array);
            calificaciones(curso, array);




            promediocalificacion = totalcalificaciones / totalestudiantes;

            Console.WriteLine("El promedio es={0}", promediocalificacion);
            Console.WriteLine("Mayor Calificacion={0}", mayorcalificacion);
            Console.WriteLine("Menor Calificacion={0}", menorcalificacion);





        }

        public void cantidadestudiante(int curso,int[][] array)
        {
            int estudiante = 0;
            for (int i = 0; i < curso; i++)
            {
                Console.Write("Ingrese la cantidad de estudiantes del curso {0}: ", i + 1);

                estudiante = Convert.ToInt32(Console.ReadLine());
                totalestudiantes += estudiante;

                array[i] = new int[estudiante];
            }
        }

        public void calificaciones( int curso, int [][] array)
        {
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

                    if (menorcalificacion > array[i][j])
                    {
                        menorcalificacion = array[i][j];
                    }
                    totalcalificaciones += array[i][j];
                }
            }
        }
    }
}
