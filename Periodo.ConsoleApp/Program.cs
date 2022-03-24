using System;

namespace Periodo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MenuPrincipal menu = new();
            CalculoDatas calculoDatas = new ();

            menu.MenuInserirDados();

            calculoDatas.menuPrincipal = menu;

            calculoDatas.PeriodosDiasAtras();

            Console.ReadLine();



        }
    }
}
