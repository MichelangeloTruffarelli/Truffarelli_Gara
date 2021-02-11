using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Truffarelli_Gara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quanti sono i partecipanti? ");
            int p = int.Parse(Console.ReadLine());

            List<string> partecipanti = new List<string>();

            for (int z = 1; z <= p; z++)
            {
                Console.WriteLine($"Nome del partecipante {z}: ");
                string nome = Console.ReadLine();

                partecipanti.Add(nome);

                Thread t = new Thread(() => Corri(nome));
                t.Start();
            }
            Console.ReadLine();
        }

        private static void Corri(string nome)
        {
            for (int z = 1; z < 100; z++)
            {
                Console.WriteLine($"Il partecipante {nome} è al km {z}.");
            }
            Console.WriteLine($"Il partecipante {nome} è arrivato al km 100 e ha finito.");
        }
    }
}
