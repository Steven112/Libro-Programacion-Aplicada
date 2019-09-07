using System;
using System.Collections.Generic;
using System.Text;

namespace PorgramacionAplicada.Tarea2
{
    class FechaHora
    {
        public void fechayhora()
        {
            DateTime hora = DateTime.Now;

            Console.WriteLine("La hora es {0:h:mtt Dia: d-M}",hora);
        }
    }
}
