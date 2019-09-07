using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace PorgramacionAplicada.Tarea2
{
    class Diccionario
    {
        public void Hash()
        {
            Hashtable diccionaio = new Hashtable();


           


            diccionaio.Add("Abadesa", "Nombre dado por algunos autores clasicos españoles a la alcachueta o ama de manceiba");
            diccionaio.Add("Abreviatura", "Representacion de una palabra mediante alguna de sus letras.");
            diccionaio.Add("Barroquismo", "Estilo farragoso y recargado. Por extensión, mal gusto.");
            diccionaio.Add("Bernardia", "Palabra jactanciosa dicha con arrogancia cuyo fin es engañar (Literatura del Siglo de Oro).");
            diccionaio.Add("Cabalistico", "Valor enigmático de las letras y los números. Ej. La literatura sobre la alquimia es cabalística.");
            diccionaio.Add("Cadencia", "Distribución de sonidos y acentos en un texto literario.");
            diccionaio.Add("Dactilo", "Pie de poesía griega que contiene una primera sílaba larga y las dos restantes breves.");
            diccionaio.Add("Decasilabo", "Verso formado por diez sílabas. Poco frecuentes en la literatura española");
            diccionaio.Add("Ectasis", "Licencia poética que permite alargar una sílaba breve para conseguir la medida del verso.");
            diccionaio.Add("Eneadecasilabos", "Versos de diez y nueve sílabas.");
            diccionaio.Add("Figuron", "En el teatro, personaje que aparenta gran importancia pero tiene poco contenido.");
            diccionaio.Add("Filologia", "Ciencia que se ocupa del estudio de la lengua y la literatura.");

            foreach(string ID in diccionaio.Keys)
            {
                System.Console.WriteLine(ID);
            }
            string valor;
            Console.WriteLine("");
            Console.WriteLine("Ingrese la palabra a buscar:");
            valor = Convert.ToString(Console.ReadLine());

            Console.WriteLine(diccionaio[valor]);



        }
    }
}
