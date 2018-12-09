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


        public List<Card> MixTheCards(List<Card> cards)
        {

            var shuffledCards = cards.OrderBy(n => Guid.NewGuid());

            foreach (var item in cards)
            {
                Console.WriteLine($"{item}");
            }

            return shuffledCards.ToList();
        }


        public void ShowClubs(List<Card> cards)
        {

            var clubs = cards.Where(x => x.Suit == Suit.clubs).ToList();
            foreach (var item in clubs)
            {                
                item.ShowACard();
            }

        }

    }

}




