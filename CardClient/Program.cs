using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLib;

namespace CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Card tempCard = myDeck.GetCard(i);
                Console.Write(tempCard.ToString());
                if (i != 51)
                    Console.Write(", ");
                else
                    Console.WriteLine();
            }

            Console.WriteLine();
            Deck deck1 = new Deck();
            try
            {
                Card myCard = deck1.GetCard(60);
            }
            catch (CardOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.DeckContents[0]);
            }

            Console.ReadKey();
        }
    }
}
