using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodo.ConsoleApp
{
    public class CalculoDatas
    {
        public MenuPrincipal menuPrincipal;

        public void PeriodosDiasAtras()
        {
            TimeSpan diasAtras;

            diasAtras = DateTime.Now - menuPrincipal.dataInserida  ;
            if(diasAtras.Days < 7)
            {
                Console.WriteLine(diasAtras.Days + "dias atras");
            }

            else if(diasAtras.Days < 30)
            {
                int semanas = diasAtras.Days / 7;
                
                Console.Write(semanas + " semanas atras ");
            }

            else if(diasAtras.Days < 365)
            {
                int mes = diasAtras.Days / 30;
                
                Console.WriteLine(mes + " mes(es) atras");
            }

            else if (diasAtras.Days >= 365)
            {
                int ano = diasAtras.Days / 365;
                int mesanos = ano - (diasAtras.Days / 30);
                Console.WriteLine(ano + " ano(s) atras e " + mesanos + " meses atras");
            }

        }
        
    }
}
