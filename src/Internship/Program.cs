using System;

namespace Internship
{
    class Program
    {
        private static void Main()
        {
            // var deck = new Deck(name: "Default");
            
            _deck.AddCard(companyName: "Microsoft");
            _deck.AddCard(companyName: "Google", status: "Applied");
            _deck.AddCard(companyName: "Amazon");
            _deck.DeleteCard(index: 1);
            
            DrawHeader(_deck.Name);
            DrawDeck(_deck);
        }

        private static Deck _deck = new Deck(name: "Default");

        private static void DrawHeader(string deckName)
        {
            var title = $"INTERNSHIP (Deck: {deckName})";
            var separator = $"##########################";

            Console.WriteLine(title);
            Console.WriteLine(separator);
            Console.WriteLine("");
        }

        private static void DrawDeck(Deck deck)
        {
            Console.WriteLine($"{"Company",-15}{"Status",-15}{"Deadline",-15}");
            Console.WriteLine($"{"-------",-15}{"------",-15}{"--------",-15}");
            if (deck.Cards.Count == 0)
            {
                Console.WriteLine("Nothing in Deck");
            }
            else
            {
                foreach (var card in deck.Cards)
                {
                    DrawCard(card);
                }
            }
        }

        private static void DrawCard(Card card)
        {
            Console.WriteLine($"{card.CompanyName,-15}{card.Status,-15}{card.Deadline,-15}");
        }
    }
}