using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodo.ConsoleApp
{
    public class MenuPrincipal
    {
        public DateTime dataInserida;
        public DateTime MenuInserirDados()
        {
            
            Console.WriteLine("digite uma data(dd/mm/aa)");
            dataInserida = Convert.ToDateTime(Console.ReadLine());
            return dataInserida;
        }

    }

}
