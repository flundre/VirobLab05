using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirobLab05
{
    class Player
    {
        public string name;
        public List<Card> cards = new List<Card>();
        public int Amount { get { return cards.Count; } }
        public Player(string n)
        {
            name = n;
        }
        public void Take(Card card) 
        {
            cards.Add(card);
        }
        public void TakeRange(List<Card> card)
        {
            cards.AddRange(card);
        }
        public Card Give()
        {
            Random rand = new Random();
            int pos = rand.Next(Amount);
            Card temp = cards[pos];
            cards.Remove(temp);
            return temp;
        }
        public void RemoveAt(int pos)
        {
            cards.RemoveAt(pos);
        }
        public override string ToString()
        {
            string temp = string.Empty;
            for(int i = 0; i < cards.Count; ++i)
            {
                temp += cards[i].ToString() + " ";
            }
            return $"{name} {temp}\n";
        }

    }
}
