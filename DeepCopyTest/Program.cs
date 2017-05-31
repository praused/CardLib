﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLib;

namespace DeepCopyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            Deck deck2 = (Deck)deck1.Clone();
            Console.WriteLine($"The first card in the original deck is {deck1.GetCard(0)}.");
            Console.WriteLine($"The first card in the cloned deck is {deck2.GetCard(0)}.");
            deck1.Shuffle();
            Console.WriteLine("Original deck shuffled.");
            Console.WriteLine($"The first card in the original deck is {deck1.GetCard(0)}.");
            Console.WriteLine($"The first card in the cloned deck is {deck2.GetCard(0)}.");
            Console.ReadKey();
        }
    }
}
