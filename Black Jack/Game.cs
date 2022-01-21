using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Jack
{
    class Game
    {
        static Random rnd = new Random();
        public List<Card> deck;
        public Player player { get; private set; }
        public Dealer dealer { get; private set; }

        public Game()
        {
            player = new Player();
            dealer = new Dealer();
        }

        public void CreateDeck()
        {
            deck = new List<Card>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card((Card.Ranks)i, (Card.Suits)j);
                    string path = "Cards/" + card.suit.ToString() + "/" + card.rank.ToString() + ".png";
                    card.image = path;
                    deck.Add(card);
                }
            }
        }

        public void Distribution()
        {
            player.AddCard(deck);
            dealer.AddCard(deck);
            player.AddCard(deck);
            dealer.AddCard(deck);
        }

        public void DealersTurn()
        {
            while (dealer.GetPoints() <= 17)
            {
                dealer.AddCard(deck);
            }

            while (MakeDecision())
            {
                dealer.AddCard(deck);
            }
        }

        public void DealersTurn(PictureBox pb)
        {
            while (dealer.GetPoints() <= 16)
            {
                dealer.AddCard(deck);
            }

            while (MakeDecision())
            {
                dealer.AddCard(deck);

                if (dealer.GetPoints() >= 20)
                    break;

                pb.Invalidate();
            }
        }

        public bool MakeDecision()
        {
            return rnd.Next() % 2 == 1;
        }

        public void ShowResult()
        {
            if (dealer.GetPoints() > 21)
            {
                MessageBox.Show("Выигрыш");
            }
            else if (dealer.GetPoints() == player.GetPoints())
            {
                MessageBox.Show("Ничья");
            }
            else if (dealer.GetPoints() > player.GetPoints())
            {
                MessageBox.Show("Проигрыш");
            }
            else if (dealer.GetPoints() < player.GetPoints())
            {
                MessageBox.Show("Выигрыш");
            }
        }

        public bool CheckCases()
        {
            if (player.GetPoints() == 21)
            {
                MessageBox.Show("Выигрыш");
                return false;
            }
            else if (player.GetPoints() > 21)
            {
                MessageBox.Show("Проигрыш");
                return false;
            }
            else if (player.GetPoints() == 22 && player.cards.Count == 2)
            {
                MessageBox.Show("Выигрыш");
                return false;
            }
            return true;
        }

        public void Reset()
        {
            player.ResetCards();
            dealer.ResetCards();
            CreateDeck();
        }
    }
}
