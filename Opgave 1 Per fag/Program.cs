﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1_Per_fag
{
    class Program
    {
        static void Main(string[] args)
        {
            int pris, betaling;
            int tilbage_betal;
            int tyver, tier, femer, toer, ener;

            Console.WriteLine("Hvad er prisen i hele tal?");
            pris = int.Parse(Console.ReadLine());

            Console.WriteLine("Hvad betaler du med i hele tal?");
            betaling = int.Parse(Console.ReadLine());

            tilbage_betal = betaling - pris;

            if (pris > betaling)
            {
                Console.WriteLine("Det er vist ikke nok betaling");
            }

            tyver = tilbage_betal / 20;
            tilbage_betal = tilbage_betal % 20;
            if (tyver > 0)
            {
                Console.WriteLine("Du får {0} 20'er tilbage ", tyver);
            }

            tier = tilbage_betal / 10;
            tilbage_betal = tilbage_betal % 10;
            if (tier > 0)
            {
                Console.WriteLine("Du får {0} 10'er tilbage ", tier);
            }

            femer = tilbage_betal / 5;
            tilbage_betal = tilbage_betal % 5;
            if (femer > 0)
            {
                Console.WriteLine("Du får {0} 5'er tilbage ", femer);
            }

            toer = tilbage_betal / 2;
            tilbage_betal = tilbage_betal % 2;
            if (toer > 0)
            {
                Console.WriteLine("Du får {0} 2'er tilbage ", toer);
            }

            ener = tilbage_betal / 1;
            tilbage_betal = tilbage_betal % 1;
            if (ener > 0)
            {
                Console.WriteLine("Du får {0} 1'er tilbage ", ener);
            }

        }
    }
}