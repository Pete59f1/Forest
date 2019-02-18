using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Deck
    {
        public static List<Card> GenerateCardDeck()
        {
            List<Card> cards = new List<Card>();
            for (int i = 2; i <= 14; i++)
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    cards.Add(new Card {Suit = suit, Value = i, Name = Card.GenerateName(i, suit), Picture = Card.GeneratePicture(i, suit)});
                }
            }
            return ShuffleDeck(cards);
        }

        private static List<Card> ShuffleDeck(List<Card> cards)
        {
            List<Card> shuffledDeck = cards.ToList();
            Random ran = new Random();
            for (int i = shuffledDeck.Count - 1; i > 0; i--)
            {
                int r = ran.Next(i + 1);
                Card temp = shuffledDeck[i];
                shuffledDeck[i] = shuffledDeck[r];
                shuffledDeck[r] = temp;
            }
            return shuffledDeck;
        }
    }
}
