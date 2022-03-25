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
                int dias = diasAtras.Days - (semanas * 7);
                if(dias < 0)
                Console.Write(semanas + " semanas atras ");

                else
                    Console.Write(semanas + " semanas e " +dias+ " dias atras");

            }

            else if(diasAtras.Days < 365)
            {
                int mes = diasAtras.Days / 30;
                int semanas = mes * 30;

                int diasousemanas = (diasAtras.Days - semanas);
                if(diasousemanas > 7)
                {
                    int semanafinal = diasousemanas / 7;
                    Console.WriteLine(mes + " Mes(es) e " +semanafinal+ " semanas atras.");
                }
                else
                {
                    Console.WriteLine(mes + " mes(es) e " +diasousemanas+ " dia(as) atras");
                }
                
                
            }

            else if (diasAtras.Days >= 365)
            {
                int ano = diasAtras.Days / 365;
                int mesanos =  (ano * 365);
                int mestotal = (diasAtras.Days - mesanos) / 30;

                if (mestotal > 0)
                {
                    Console.WriteLine(ano + " ano(s) atras e " + mestotal + " meses atras");
                }
                else
                Console.WriteLine(ano + " ano(s) atras");
            }

        }
        
    }
}
