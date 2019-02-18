using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Card
    {
        private int value;
        private Suit suit;
        private string picture;
        private string name;

        public int Value { get { return value; } set { this.value = value; } }
        public Suit Suit { get { return suit; } set { suit = value; } }
        public string Picture { get { return picture; } set { picture = value; } }
        public string Name { get { return name; } set { name = value; } }

        public static string GenerateName(int value, Suit suit)
        {
            string name = null;

            if (value >= 2 || value <= 10)
            {
                name = value.ToString();
            }
            else if (value == 11)
            {
                name = "Jack";
            }
            else if (value == 12)
            {
                name = "Queen";
            }
            else if (value == 13)
            {
                name = "King";
            }
            else if (value == 14)
            {
                name = "Ace";
            }
            return name + " of " + Enum.GetName(typeof(Suit), suit);
        }

        public static string GeneratePicture(int value, Suit suit)
        {
            string picture = "Ikke Done";
            return picture;
        }
    }
}
