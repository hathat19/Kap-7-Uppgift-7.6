using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Uppgift7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> varaPris = new Dictionary<string, int>();
            string användarensInput = "";

            //Input
            while (true)
            {
                varaPris.Clear();

                Console.WriteLine("Skriv in namn på matvaror:");
                användarensInput = Console.ReadLine();
                string[] namnPåVarorna = användarensInput.Split(" ");

                Console.WriteLine("Skriv in pris på varorna:");
                användarensInput = Console.ReadLine();
                string[] prisPåVarornaString = användarensInput.Split(" ");

                if (prisPåVarornaString.Length != namnPåVarorna.Length)
                {
                    Console.WriteLine("Du gjorde något fel! Försök igen!");
                    continue;
                }

                //skulle något gå fel startas loopen om. 
                try
                {
                    //Lägger in sakerna i dictionary:n. 
                    for (int i = 0; i < namnPåVarorna.Length; i++)
                    {
                        varaPris[namnPåVarorna[i]] = int.Parse(prisPåVarornaString[i]);
                    }
                }
                catch
                {
                    Console.WriteLine("Du skrev fel! Försök igen!");
                    continue;
                }
                break;
            }

            Console.WriteLine("Skriv in din handlingslista:");
            användarensInput = Console.ReadLine();
            string[] handlingslista = användarensInput.Split(" ");

            int sum = 0;
            foreach (string vara in handlingslista)
            {
                if (varaPris.ContainsKey(vara))
                {
                    sum += varaPris[vara];
                }
            }

            Console.WriteLine($"Din handlingslista kommer att kosta {sum} kronor.");
        }
    }
}
/*Skapa ett konsolprogram som ska beräkna kostaden för användarens handlingslista.
Användaren ska skriva in tre rader med information när programmet kör. Den första
raden ska vara namnen på produkterna hen ska handla, t.ex. banan citron. Nästa rad
ska innehålla styckpriset för varje matvara som skrevs in på första raden, t.ex. 5 8 om
bananer kostar 5 kr/st och citroner 8 kr/st. Sista raden ska vara användarens
handlingslista, om det står banan banan citron banan citron betyder det att man ska köpa
3 bananer och 2 citroner. Programmet ska skriva ut den totala kostnaden att köpa
det som står i handlingslistan. En körning av programmet skulle kunna se ut så här:
Skriv in namn på matvaror
banan citron
Skriv in matvarornas priser
5 8
Skriv in din handlingslista
banan banan citron banan citron
Priset för handlingslistan är 31*/