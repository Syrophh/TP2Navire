using GestionNavire.Classesmetier;
using System;

namespace GestionNavire.Application
{
    class Program
    {
        static void Main()
        {
            try
            {
                Instanciations();
                Console.WriteLine("Fin normale du programme");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {Console.ReadKey();}
        }

        private static void Instanciations()
        {
            try
            {
                Navire navire = new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827);
                navire = new Navire("IMO9839272", "MSC Isabella", "Porte-conteneurs", 197500);
                navire = new Navire("IMO8715871", "MSC PILAR", "Porte-conteneurs", 67183);
                navire = new Navire("XMT9235232", "FORTUNE TRADER", "Cargo", 74750);
                navire = new Navire("IMO9574004", "TRITON SEAHAWK", "Hydrocarbures", 51201);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
