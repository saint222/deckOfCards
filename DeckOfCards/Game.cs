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

            return shuffledCards.ToList();
        }

        public void ShowFirstFiveCardsRfomTheDeck (List<Card> cards)
        {

            var firstFive = cards.Take(5).ToList();
            foreach (var item in firstFive)
            {
                item.ShowACard();
            }

        }

        public void ShowMoreThanTenRankCards (List<Card> cards)
        {
            var moreThanTen = cards.Where(x => x.Rank > Rank.ten);
            //var moreThanTen = cards.Where(x => x.Rank != Rank.two && x.Rank != Rank.three && x.Rank!=Rank.four && x.Rank!=Rank.five && x.Rank!=Rank.six && x.Rank!=Rank.seven && x.Rank != Rank.eight && x.Rank != Rank.nine && x.Rank != Rank.ten).ToList();
            foreach (var item in moreThanTen)
            {
                item.ShowACard();
            }

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




