using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace PorgramacionAplicada.Tarea2
{
    class Agenda
    {
        public void agregar()
        {
            Hashtable Agenda= new Hashtable();

            string nombre;
            string numero;
            string agregar;


            do
            {
                Console.WriteLine("");
                Console.WriteLine("Ingrese el nombre de la persona:");
                nombre = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Ingrese el numero de la persona:");
                numero = Convert.ToString(Console.ReadLine());

                Agenda.Add(nombre, numero);

                Console.WriteLine("");
                Console.WriteLine("Desea agregar otra persona {Si/No}");
                agregar = Convert.ToString(Console.ReadLine());
            } while (agregar == "Si" || agregar == "si");







            foreach (string ID in Agenda.Keys)
            {
                System.Console.WriteLine(ID);
            }
            string valor;
            Console.WriteLine("");
            Console.WriteLine("Ingrese el nombre de la persona a buscar:");
            valor = Convert.ToString(Console.ReadLine());

            Console.WriteLine(Agenda[valor]);



        }
    }
}
