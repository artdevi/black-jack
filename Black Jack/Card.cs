using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Jack
{
    class Card
    {
        public enum Suits
        {
            Heart, Diamond, Club, Spare
        }

        public enum Ranks
        {
            Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
        }

        public Ranks rank { get; }
        public Suits suit { get; }
        public string image;

        public Card(Ranks _rank, Suits _suit, string _image)
        {
            rank = _rank;
            suit = _suit;
            image = _image;
        }

        public Card(Ranks _rank, Suits _suit)
        {
            rank = _rank;
            suit = _suit;
        }

        public void Draw(Graphics g, PictureBox pb, Point pos)
        {
            Bitmap img = new Bitmap(Image.FromFile(image));
            g.DrawImage(img, pos);
        }
    }
}
