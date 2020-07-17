using System;

namespace Radication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepgoing = true;

            while (keepgoing)
            {
                Console.Write("Escirba la potencia de la raiz: ");
                double potencia = Convert.ToDouble(Console.ReadLine());
                Radicacion rad = new Radicacion(potencia);
                Console.Write("Escirba el numero al cual le queire savar la raiz: ");
                double number = Convert.ToDouble(Console.ReadLine());



                Console.WriteLine($"Resultado: {rad.DoRadicacion(number)}");

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
