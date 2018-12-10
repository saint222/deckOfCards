using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Game game = new Game();
            var cards = game.CreateCards();
            game.MixTheCards(cards);
            game.ShowFirstFiveCardsRfomTheDeck(cards);
            game.ShowMoreThanTenRankCards(cards);
            game.ShowClubs(cards);
            Console.ReadLine();                
            

        }
    }
}
