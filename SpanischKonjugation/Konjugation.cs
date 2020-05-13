using System;

namespace SpanischKonjugation
{
    class Spanisch
    {
        static void Main(string[] args)
        {
            var vokabel = Console.ReadLine();


            if (vokabel.EndsWith("ar"))
            {
                var VokabelCut = vokabel.TrimEnd('a', 'r');
                Konjugtion(VokabelCut, 1);
            }

            else if (vokabel.EndsWith("er"))
            {
                var VokabelCut = vokabel.TrimEnd('e', 'r');
                Konjugtion(VokabelCut, 2);
            }

            else if (vokabel.EndsWith("ir"))
            {
                var VokabelCut = vokabel.TrimEnd('i', 'r');
                Konjugtion(VokabelCut, 3);
            }
            else if (vokabel.EndsWith("se"))
            {
                var VokabelCut = vokabel.TrimEnd('s', 'e');
                Konjugtion(VokabelCut, 3);
            }

        }
        public static void Konjugtion(string VokabelCut, int Ending)
        {

            // Ending = 1 AR
            // Ending = 2 ER
            // Ending = 3 IR
            // Ending = 4 SE


            if (Ending == 1)
            {
                Console.WriteLine("Konjugation ICH       : " + VokabelCut.Insert(VokabelCut.Length, "o"));
                Console.WriteLine("Konjugation DU        : " + VokabelCut.Insert(VokabelCut.Length, "as"));
                Console.WriteLine("Konjugation ER/SIE/ES : " + VokabelCut.Insert(VokabelCut.Length, "a"));
                Console.WriteLine("Konjugation WIR       : " + VokabelCut.Insert(VokabelCut.Length, "mos"));
                Console.WriteLine("Konjugation IHR       : " + VokabelCut.Insert(VokabelCut.Length, "áis"));
                Console.WriteLine("Konjugation SIE       : " + VokabelCut.Insert(VokabelCut.Length, "an"));
            }
            else if (Ending == 2)
            {
                Console.WriteLine("Konjugation ICH       : " + VokabelCut.Insert(VokabelCut.Length, "o"));
                Console.WriteLine("Konjugation DU        : " + VokabelCut.Insert(VokabelCut.Length, "es"));
                Console.WriteLine("Konjugation ER/SIE/ES : " + VokabelCut.Insert(VokabelCut.Length, "e"));
                Console.WriteLine("Konjugation WIR       : " + VokabelCut.Insert(VokabelCut.Length, "emos"));
                Console.WriteLine("Konjugation IHR       : " + VokabelCut.Insert(VokabelCut.Length, "éis"));
                Console.WriteLine("Konjugation SIE       : " + VokabelCut.Insert(VokabelCut.Length, "en"));
            }
            else if (Ending == 3)
            {
                Console.WriteLine("Konjugation ICH       : " + VokabelCut.Insert(VokabelCut.Length, "o"));
                Console.WriteLine("Konjugation DU        : " + VokabelCut.Insert(VokabelCut.Length, "es"));
                Console.WriteLine("Konjugation ER/SIE/ES : " + VokabelCut.Insert(VokabelCut.Length, "e"));
                Console.WriteLine("Konjugation WIR       : " + VokabelCut.Insert(VokabelCut.Length, "imos"));
                Console.WriteLine("Konjugation IHR       : " + VokabelCut.Insert(VokabelCut.Length, "ís"));
                Console.WriteLine("Konjugation SIE       : " + VokabelCut.Insert(VokabelCut.Length, "en"));
            }
            else if (Ending == 4)
            {
                Console.WriteLine("Konjugation ICH       : " + VokabelCut.Insert(VokabelCut.Length, "o"));
                Console.WriteLine("Konjugation DU        : " + VokabelCut.Insert(VokabelCut.Length, "as"));
                Console.WriteLine("Konjugation ER/SIE/ES : " + VokabelCut.Insert(VokabelCut.Length, "a"));
                Console.WriteLine("Konjugation WIR       : " + VokabelCut.Insert(VokabelCut.Length, "mos"));
                Console.WriteLine("Konjugation IHR       : " + VokabelCut.Insert(VokabelCut.Length, "áis"));
                Console.WriteLine("Konjugation SIE       : " + VokabelCut.Insert(VokabelCut.Length, "an"));
            }
        }

    }
}

