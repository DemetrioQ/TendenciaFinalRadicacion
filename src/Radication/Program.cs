using System;

namespace Radication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepgoing = true;
            Radicacion rad = new Radicacion();

            while (keepgoing)
            {
                Console.Write("Escirba la potencia de la raiz: ");
                string potency = Console.ReadLine();
                Console.Write("Escirba el numero al cual le queire savar la raiz: ");
                string number = Console.ReadLine();



                Console.WriteLine($"Resultado: {rad.DoRadicacion(number,potency)}");

                Console.Write("Desea sacar la raiz de otro numero? (Y/N): ");
                string choice = Console.ReadLine().ToLower();
                if (choice == "n")
                {
                    keepgoing = false;
                }

            }

        }
    }
}
