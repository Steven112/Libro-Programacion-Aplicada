using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PorgramacionAplicada.Tarea2
{
    class Lista
    {
        public void calificacion()
        {

            ArrayList calificaciones = new ArrayList();


            int cantidad, i, mayorCalificacion = 0,menorCalificacion=999999 ;
            int valorcalificaciones=0,acomulado =0;

            Console.WriteLine("Indique la cantidad de calificaciones");
            cantidad = Convert.ToInt32(Console.ReadLine());

            
            for (i = 1; i <= cantidad; i++)
            {

                Console.WriteLine("Calificacion {0}", i);
                valorcalificaciones = Convert.ToInt32(Console.ReadLine());
               
                calificaciones.Add(valorcalificaciones);
                
            }

            foreach (int numero in calificaciones)
            {
                acomulado = acomulado + numero;
                if (numero > mayorCalificacion)
                {
                    mayorCalificacion = numero;
                }
                if (numero < menorCalificacion)
                {
                    menorCalificacion = numero;
                }

                
            }
            int promedio = acomulado / cantidad;
            Console.WriteLine("Promedio={0}, Mayor Nota={1}, Menor Nota={2}", promedio, mayorCalificacion, menorCalificacion);
        }
        
    }
}
