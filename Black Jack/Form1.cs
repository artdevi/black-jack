using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Jack
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
            game = new Game();

            button_get.Enabled = false;
            button_pass.Enabled = false;
            button_play.Enabled = true;
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            game.Reset();
            game.CreateDeck();
            game.Distribution();
            label1.Text = "Dealer's Points: " + game.dealer.GetPoints().ToString();
            label2.Text = "Player's Points: " + game.player.GetPoints().ToString();

            button_get.Enabled = true;
            button_pass.Enabled = true;
            button_play.Enabled = false;

            pictureBox_player.Invalidate();
            pictureBox_dealer.Invalidate();
        }

        private void button_pass_Click(object sender, EventArgs e)
        {
            if (game.CheckCases())
            {
                game.DealersTurn(pictureBox_dealer);
                game.ShowResult();
            }

            button_get.Enabled = false;
            button_pass.Enabled = false;
            button_play.Enabled = true;

        }

        private void button_get_Click(object sender, EventArgs e)
        {
            game.player.AddCard(game.deck);
           
            pictureBox_player.Invalidate();
            pictureBox_dealer.Invalidate();
        }

        private void pictureBox_player_Paint(object sender, PaintEventArgs e)
        {
            if (game.player.cards.Count > 0)
            {
                for (int i = 0; i < game.player.cards.Count; i++)
                {
                    game.player.cards[i].Draw(e.Graphics, pictureBox_player, new Point(5 + 25 * i, 5));
                }
            }
        }

        private void pictureBox_dealer_Paint(object sender, PaintEventArgs e)
        {
            if (game.dealer.cards.Count > 0)
            {
                for (int i = 0; i < game.dealer.cards.Count; i++)
                {
                    game.dealer.cards[i].Draw(e.Graphics, pictureBox_dealer, new Point(5 + 25 * i, 5));
                }
            }

            label1.Text = "Dealer's Points: " + game.dealer.GetPoints().ToString();
            label2.Text = "Player's Points: " + game.player.GetPoints().ToString();
        }
    }
}
