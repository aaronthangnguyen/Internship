using System.Collections.Generic;

namespace Internship
{
    class Deck
    {
        public Deck(string name)
        {
            Name = name;
            Cards = new List<Card>(); // Initialize Card property
        }

        public void AddCard(string companyName, string status = "N/A", string deadline = "N/A")
        {
            var card = new Card(companyName, status, deadline);
            Cards.Add(card);
        }

        public void DeleteCard(int index)
        {
            Cards.RemoveAt(index);
        }

        public string Name { get; set; }
        public List<Card> Cards { get; }
    }
}