using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramacionAplicada.Tarea1
{
    class DiasdeSemana
    {
        public void dias()
        {
            int opcion;


            Console.WriteLine("Ingrese un numero del 1 al 7");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {

                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;


            }
        }
    }
}
