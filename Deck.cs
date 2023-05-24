using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirobLab05
{
    class Deck
    {
        public List<Card> deck = new List<Card>();
        public int Amount { get { return deck.Count; } }
        public void Shuffle()
        {
            Random rand = new Random();
            for(int i = Amount - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                Card temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }

        public void Deal(List<Player> players)
        {
            while(Amount != 0)
            {
                for(int i = 0; i < players.Count; ++i)
                {
                    players[i].Take(deck[Amount - 1]);
                    deck.RemoveAt(Amount - 1);
                }
            }
        }

        public Deck(int numb)
        {
            if(numb == 4)
            {
                deck.Add(new Card(2, Suit.heart)); deck.Add(new Card(3, Suit.heart)); deck.Add(new Card(4, Suit.heart));
                deck.Add(new Card(5, Suit.heart)); deck.Add(new Card(6, Suit.heart)); deck.Add(new Card(7, Suit.heart));
                deck.Add(new Card(8, Suit.heart)); deck.Add(new Card(9, Suit.heart)); deck.Add(new Card(10, Suit.heart));
                deck.Add(new Card(11, Suit.heart)); deck.Add(new Card(12, Suit.heart)); deck.Add(new Card(13, Suit.heart));
                deck.Add(new Card(14, Suit.heart));
                deck.Add(new Card(2, Suit.diamond)); deck.Add(new Card(3, Suit.diamond)); deck.Add(new Card(4, Suit.diamond));
                deck.Add(new Card(5, Suit.diamond)); deck.Add(new Card(6, Suit.diamond)); deck.Add(new Card(7, Suit.diamond));
                deck.Add(new Card(8, Suit.diamond)); deck.Add(new Card(9, Suit.diamond)); deck.Add(new Card(10, Suit.diamond));
                deck.Add(new Card(11, Suit.diamond)); deck.Add(new Card(12, Suit.diamond)); deck.Add(new Card(13, Suit.diamond));
                deck.Add(new Card(14, Suit.diamond));
                deck.Add(new Card(2, Suit.club)); deck.Add(new Card(3, Suit.club)); deck.Add(new Card(4, Suit.club));
                deck.Add(new Card(5, Suit.club)); deck.Add(new Card(6, Suit.club)); deck.Add(new Card(7, Suit.club));
                deck.Add(new Card(8, Suit.club)); deck.Add(new Card(9, Suit.club)); deck.Add(new Card(10, Suit.club));
                deck.Add(new Card(11, Suit.club)); deck.Add(new Card(12, Suit.club)); deck.Add(new Card(13, Suit.club));
                deck.Add(new Card(14, Suit.club));
                deck.Add(new Card(2, Suit.spade)); deck.Add(new Card(3, Suit.spade)); deck.Add(new Card(4, Suit.spade));
                deck.Add(new Card(5, Suit.spade)); deck.Add(new Card(6, Suit.spade)); deck.Add(new Card(7, Suit.spade));
                deck.Add(new Card(8, Suit.spade)); deck.Add(new Card(9, Suit.spade)); deck.Add(new Card(10, Suit.spade));
                deck.Add(new Card(11, Suit.spade)); deck.Add(new Card(12, Suit.spade)); deck.Add(new Card(13, Suit.spade));
                deck.Add(new Card(14, Suit.spade));
            }
            else if (numb == 5)
            {
                deck.Add(new Card(3, Suit.heart)); deck.Add(new Card(4, Suit.heart));
                deck.Add(new Card(5, Suit.heart)); deck.Add(new Card(6, Suit.heart)); deck.Add(new Card(7, Suit.heart));
                deck.Add(new Card(8, Suit.heart)); deck.Add(new Card(9, Suit.heart)); deck.Add(new Card(10, Suit.heart));
                deck.Add(new Card(11, Suit.heart)); deck.Add(new Card(12, Suit.heart)); deck.Add(new Card(13, Suit.heart));
                deck.Add(new Card(14, Suit.heart));
                deck.Add(new Card(3, Suit.diamond)); deck.Add(new Card(4, Suit.diamond));
                deck.Add(new Card(5, Suit.diamond)); deck.Add(new Card(6, Suit.diamond)); deck.Add(new Card(7, Suit.diamond));
                deck.Add(new Card(8, Suit.diamond)); deck.Add(new Card(9, Suit.diamond)); deck.Add(new Card(10, Suit.diamond));
                deck.Add(new Card(11, Suit.diamond)); deck.Add(new Card(12, Suit.diamond)); deck.Add(new Card(13, Suit.diamond));
                deck.Add(new Card(14, Suit.diamond));
                deck.Add(new Card(2, Suit.club)); deck.Add(new Card(3, Suit.club)); deck.Add(new Card(4, Suit.club));
                deck.Add(new Card(5, Suit.club)); deck.Add(new Card(6, Suit.club)); deck.Add(new Card(7, Suit.club));
                deck.Add(new Card(8, Suit.club)); deck.Add(new Card(9, Suit.club)); deck.Add(new Card(10, Suit.club));
                deck.Add(new Card(11, Suit.club)); deck.Add(new Card(12, Suit.club)); deck.Add(new Card(13, Suit.club));
                deck.Add(new Card(14, Suit.club));
                deck.Add(new Card(2, Suit.spade)); deck.Add(new Card(3, Suit.spade)); deck.Add(new Card(4, Suit.spade));
                deck.Add(new Card(5, Suit.spade)); deck.Add(new Card(6, Suit.spade)); deck.Add(new Card(7, Suit.spade));
                deck.Add(new Card(8, Suit.spade)); deck.Add(new Card(9, Suit.spade)); deck.Add(new Card(10, Suit.spade));
                deck.Add(new Card(11, Suit.spade)); deck.Add(new Card(12, Suit.spade)); deck.Add(new Card(13, Suit.spade));
                deck.Add(new Card(14, Suit.spade));
            }
            else if (numb == 6)
            {
                deck.Add(new Card(3, Suit.heart)); deck.Add(new Card(4, Suit.heart));
                deck.Add(new Card(5, Suit.heart)); deck.Add(new Card(6, Suit.heart)); deck.Add(new Card(7, Suit.heart));
                deck.Add(new Card(8, Suit.heart)); deck.Add(new Card(9, Suit.heart)); deck.Add(new Card(10, Suit.heart));
                deck.Add(new Card(11, Suit.heart)); deck.Add(new Card(12, Suit.heart)); deck.Add(new Card(13, Suit.heart));
                deck.Add(new Card(14, Suit.heart));
                deck.Add(new Card(3, Suit.diamond)); deck.Add(new Card(4, Suit.diamond));
                deck.Add(new Card(5, Suit.diamond)); deck.Add(new Card(6, Suit.diamond)); deck.Add(new Card(7, Suit.diamond));
                deck.Add(new Card(8, Suit.diamond)); deck.Add(new Card(9, Suit.diamond)); deck.Add(new Card(10, Suit.diamond));
                deck.Add(new Card(11, Suit.diamond)); deck.Add(new Card(12, Suit.diamond)); deck.Add(new Card(13, Suit.diamond));
                deck.Add(new Card(14, Suit.diamond));
                deck.Add(new Card(3, Suit.club)); deck.Add(new Card(4, Suit.club));
                deck.Add(new Card(5, Suit.club)); deck.Add(new Card(6, Suit.club)); deck.Add(new Card(7, Suit.club));
                deck.Add(new Card(8, Suit.club)); deck.Add(new Card(9, Suit.club)); deck.Add(new Card(10, Suit.club));
                deck.Add(new Card(11, Suit.club)); deck.Add(new Card(12, Suit.club)); deck.Add(new Card(13, Suit.club));
                deck.Add(new Card(14, Suit.club));
                deck.Add(new Card(3, Suit.spade)); deck.Add(new Card(4, Suit.spade));
                deck.Add(new Card(5, Suit.spade)); deck.Add(new Card(6, Suit.spade)); deck.Add(new Card(7, Suit.spade));
                deck.Add(new Card(8, Suit.spade)); deck.Add(new Card(9, Suit.spade)); deck.Add(new Card(10, Suit.spade));
                deck.Add(new Card(11, Suit.spade)); deck.Add(new Card(12, Suit.spade)); deck.Add(new Card(13, Suit.spade));
                deck.Add(new Card(14, Suit.spade));
            }
            else if(numb < 4)
            {
                deck.Add(new Card(6, Suit.heart)); deck.Add(new Card(7, Suit.heart));
                deck.Add(new Card(8, Suit.heart)); deck.Add(new Card(9, Suit.heart)); deck.Add(new Card(10, Suit.heart));
                deck.Add(new Card(11, Suit.heart)); deck.Add(new Card(12, Suit.heart)); deck.Add(new Card(13, Suit.heart));
                deck.Add(new Card(14, Suit.heart));
                deck.Add(new Card(6, Suit.diamond)); deck.Add(new Card(7, Suit.diamond));
                deck.Add(new Card(8, Suit.diamond)); deck.Add(new Card(9, Suit.diamond)); deck.Add(new Card(10, Suit.diamond));
                deck.Add(new Card(11, Suit.diamond)); deck.Add(new Card(12, Suit.diamond)); deck.Add(new Card(13, Suit.diamond));
                deck.Add(new Card(14, Suit.diamond));
                deck.Add(new Card(6, Suit.club)); deck.Add(new Card(7, Suit.club));
                deck.Add(new Card(8, Suit.club)); deck.Add(new Card(9, Suit.club)); deck.Add(new Card(10, Suit.club));
                deck.Add(new Card(11, Suit.club)); deck.Add(new Card(12, Suit.club)); deck.Add(new Card(13, Suit.club));
                deck.Add(new Card(14, Suit.club));
                deck.Add(new Card(6, Suit.spade)); deck.Add(new Card(7, Suit.spade));
                deck.Add(new Card(8, Suit.spade)); deck.Add(new Card(9, Suit.spade)); deck.Add(new Card(10, Suit.spade));
                deck.Add(new Card(11, Suit.spade)); deck.Add(new Card(12, Suit.spade)); deck.Add(new Card(13, Suit.spade));
                deck.Add(new Card(14, Suit.spade));
            }
        }
    }
}
