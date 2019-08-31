using System;

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


            Console.WriteLine("Menu");
            Console.WriteLine("1.1 Cree un proyecto nuevo que imprima su nombre en la ventana de la consola");
            Console.WriteLine("1.5 Agregue más mensajes a la aplicación que ha creado");

            Console.WriteLine("2.1 Hacer un programa que calcule el perímetro de cualquier polígono regular.");
            Console.WriteLine("2.3 Hacer un programa que transforme de grados a radianes.");
            Console.WriteLine("2.5 Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.");

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

                 default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }


        }
    }
}
