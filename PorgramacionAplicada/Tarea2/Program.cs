﻿using System;
using System.Collections;
using PorgramacionAplicada.Tarea2;
namespace PorgramacionAplicada.Tarea1


{
    class Program
    {
        static void Main(string[] args)
        {
             int opcion;
             Dialogo d = new Dialogo();
             Perimetro op = new Perimetro();
             ConversionGrados_Rad conv1 = new ConversionGrados_Rad();
             Conversion_Monedad conv2 = new Conversion_Monedad();
             Area_Perimetro ap = new Area_Perimetro();
             PareImpares pares = new PareImpares();
             DiasdeSemana ds = new DiasdeSemana();
             Potencia pt = new Potencia();
             TablaMultiplicar tn = new TablaMultiplicar();
             PromedioEstudiantes pe = new PromedioEstudiantes();
            //Cap 5-8
            Factorial factorial = new Factorial();
            FuncionCadena funcion = new FuncionCadena();
            PromedioJagged promedio = new PromedioJagged();
            FechaHora tiempo = new FechaHora();
            PromedioJaggedFunciones promediofuncio = new PromedioJaggedFunciones(); 



            Console.WriteLine("Menu");
             Console.WriteLine("Capitulo 1");
             Console.WriteLine("1-Cree un proyecto nuevo que imprima su nombre en la ventana de la consola y Agregue más mensajes a la aplicación que ha creado.");

             Console.WriteLine("Capitulo 2");
             Console.WriteLine("2-Hacer un programa que calcule el perímetro de cualquier polígono regular.");
             Console.WriteLine("3-Hacer un programa que transforme de grados a radianes.");
             Console.WriteLine("4-Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.");

             Console.WriteLine("Capitulo 3");
             Console.WriteLine("5-Hacer un programa que le pida al usuario un numero y le diga si es par o impar.");
             Console.WriteLine("6-Hacer un programa que le pida al usuario un número del 1 al 7 y escriba el nombre del día que corresponde ese número en la semana..");
             Console.WriteLine("7-Hacer una programa que pueda calcular el perímetro y el área de cualquier polígono regular, pero que le pregunte al usuario qué desea calcular.");

             Console.WriteLine("Capitulo 4");
             Console.WriteLine("8-Hacer un programa que muestre la tabla de multiplicar del 1 al 10 de cualquier número.");
             Console.WriteLine("9-Hacer un programa que calcule el resultado de un número elevado a cualquier potencia.");
             Console.WriteLine("10-Hacer un programa que calcule el promedio de edad de un grupo de personas y diga cuál es la de edad más grande y cuál es la más joven");

            Console.WriteLine("Capitulo 5");
            Console.WriteLine("11-Hacer una función que calcule el factorial de un número.");
            Console.WriteLine("12-Hacer una función que dado un número nos regrese una cadena donde se encuentre escrito en palabras.");

            Console.WriteLine("Capitulo 6");
            Console.WriteLine("13-Agregar el cálculo del promedio para el programa con arreglo jagged. 2 Agregar el cálculo de la menor calificación para el programa con arreglo ged.");
            Console.WriteLine("13-Agregar el cálculo de la mayor calificación para el programa con arreglo jagged.");
            Console.WriteLine("14-Modificar el programa de la escuela para que utilice funciones. 5 Crear un programa que pase un arreglo jagged como parámetro a una función");


            do
             {
                 Console.WriteLine("Ingrese la opcion a elergir");
                 opcion = Convert.ToInt32(Console.ReadLine());

                 switch (opcion)
                 {

                     case 1:
                         d.mensajes();
                         break;
                     case 2:
                         op.perimetro();
                         break;
                     case 3:
                         conv1.grados_radianes();
                         break;

                     case 4:
                         conv2.dolar_euros();
                         break;
                     case 5:
                         pares.par_impar();
                         break;
                     case 6:
                         ds.dias();
                         break;
                     case 7:
                         ap.area_perim();
                         break;
                     case 8:
                         tn.tabla();
                         break;
                     case 9:
                         pt.elevar();
                         break;
                     case 10:
                         pe.promedio();
                         break;
                     case 11:
                        factorial.factor();
                         break;
                     case 12:
                        funcion.cadena();
                        break;
                    case 13:
                        promedio.promedio();
                        break;
                    case 14:
                        promediofuncio.promedio();
                        break;
                    case 15:
                        break;

                     default:
                         Console.WriteLine("Opcion no valida");
                         break;
                 }
             } while (opcion != 15);

           
            // funcion.cadena();

            //factorial.factor();

           

            // promedio.promedio();

          

            tiempo.fechayhora();
            


        }
    }
}
