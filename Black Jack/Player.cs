using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Player
    {
        Random rnd;
        public string name;
        public int money;
        public List<Card> cards { get; private set; }

        public Player()
        {
            rnd = new Random();
            money = 1000;
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
