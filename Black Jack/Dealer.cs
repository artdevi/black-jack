using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Dealer
    {
        Random rnd;
        public List<Card> cards;

        public Dealer()
        {
            rnd = new Random();
            ResetCards();
        }

        public void ResetCards()
        {
            cards = new List<Card>();
        }

        public void AddCard(List<Card> deck)
        {
            int index = rnd.Next(0, deck.Count);
            cards.Add(deck[index]);
            deck.RemoveAt(index);
        }

        public int GetPoints()
        {
            int points = 0;
            foreach (Card card in cards)
            {
                switch (card.rank)
                {
                    case Card.Ranks.Six:
                        points += 6;
                        break;
                    case Card.Ranks.Seven:
                        points += 7;
                        break;
                    case Card.Ranks.Eight:
                        points += 8;
                        break;
                    case Card.Ranks.Nine:
                        points += 9;
                        break;
                    case Card.Ranks.Ten:
                        points += 10;
                        break;
                    case Card.Ranks.Jack:
                        points += 2;
                        break;
                    case Card.Ranks.Queen:
                        points += 3;
                        break;
                    case Card.Ranks.King:
                        points += 4;
                        break;
                    case Card.Ranks.Ace:
                        points += 11;
                        break;
                }
            }
            return points;
        }
    }
}
