using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GÆT_ET_TAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();
            bool gættet = false;
            int antalgæt = 0;

            int gæt;
            int hemelig = rdn.Next(1, 7);
            Console.WriteLine("skiv en tal mellem 1 og 6");
            do
            {
                gæt = int.Parse(Console.ReadLine());
                Console.Clear();
                antalgæt++;

                if (gæt == hemelig)
                {
                    gættet = true;
                    
                }
                else if (gæt < hemelig)
                {
                    Console.WriteLine("kom igen tallet er højere end dit gæt");
                }
                else
                {
                    Console.WriteLine("kom igen tallet er lavere end dit gæt");
                }
            } while (gættet == false);

            switch (antalgæt)
            {
                case 1:
                    Console.WriteLine("WOOW du er mega god til at gætte du gætede det rigtige tal på kun 1 forsøg");
                    break;

                case 2:
                    Console.WriteLine("godt gættet du brugte 2 forsøg på det");
                    break;

                case 3:
                    Console.WriteLine("DU gæted edet på 3 forsøg det er okay");
                    break;

                case 4:
                    Console.WriteLine("Den klarede du ikke så godt du brugte 4 forsøg på det");
                    break;

                case 5:
                    Console.WriteLine("Den klarede du dårligt det tog hele 5 forsøg");
                    break;

                default:
                    Console.WriteLine("Det var fadme dårligt ja faktisk kune det ikke være værede 6 forsøg brugt");
                    break;

                    
            }

            Console.ReadKey();

        }
    }
}
