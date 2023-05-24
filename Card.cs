using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirobLab05
{
    public enum Suit { heart, diamond, club, spade}
    class Card
    {
        public uint power;
        public Suit suit;

        public Card(uint p, Suit s)
        {
            power = p;
            suit = s;
        }

        public string Closed()
        {
            return "|XXXXXXXXXXXX|";
        }

        public override string ToString()
        {
           switch(power) {
                case 2:
                    return $"|2 of {suit}|";
                case 3:
                    return $"|3 of {suit}|";
                case 4:
                    return $"|4 of {suit}|";
                case 5:
                    return $"|5 of {suit}|";
                case 6:
                    return $"|6 of {suit}|";
                case 7:
                    return $"|7 of {suit}|";
                case 8:
                    return $"|8 of {suit}|";
                case 9:
                    return $"|9 of {suit}|";
                case 10:
                    return $"|10 of {suit}|";
                case 11:
                    return $"|Jack of {suit}|";
                case 12:
                    return $"|Queen of {suit}|";
                case 13:
                    return $"|King of {suit}|";
                case 14:
                    return $"|Ace of {suit}|";
                default:
                    throw new Exception($"Wrong power input - power must be in range [2, 14]");
            };
        }
        public static bool operator ==(Card obj1, Card obj2)
        {
            return (obj1.power == obj2.power);
        }
        public static bool operator !=(Card obj1, Card obj2)
        {
            return (obj1.power != obj2.power);
        }
    }
}
