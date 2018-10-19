using System;

namespace CountTheLowercaseAs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"My MUm trIEs tO bE cOOL by sayIng thAt shE LIkEs ALL thE sAmE thIngs that I dO.
I chEckEd tO mAkE sUrE that hE wAs stILL ALIvE.
YEAh, I thInk It's a gOOd EnvIrOnmEnt fOr LEArnIng EngLIsh.
ThE sky Is cLEAr; thE stArs ArE twInkLIng.
A sOng cAn mAkE Or rUIn A pErsOn’s day If thEy LEt It gEt tO thEm.";

            int result = CountTheLowercaseLetterAs(input);

            Console.WriteLine($"There are {result} lowercase A's in the input string.");
            Console.ReadKey();
        }

        private static int CountTheLowercaseLetterAs(string input)
        {
            int foundCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('a'))
                {
                    foundCount++;
                }
            }

            return foundCount;
        }
    }
}
