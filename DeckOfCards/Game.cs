using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Game

    {
        
        public List<Card> CreateCards()
        {
            List<Card> cards = new List<Card>();

            foreach (var suit in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                foreach (var rank in (Rank[])Enum.GetValues(typeof(Rank)))
                {
                    Card card = new Card() { Suit = suit, Rank = rank };

                    cards.Add(card);
                }

            }
                        
            return cards;
        }


        public List<Card> MixTheCards (List<Card> cards)
        {
            var sortedCards = cards.OrderBy(u => u.Rank).ThenBy(u => u.Suit);
          
            foreach (var item in cards)
            {
                Console.WriteLine($"{item}");
            }    
            
            return sortedCards.ToList();
        }


    }

}


