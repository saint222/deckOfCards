using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Card

    {
        public Rank Rank { get; set; }
        public Suit Suit { get; set; }

        //public Card(Rank rank, Suit suit)
        //{
        //    Rank = rank;
        //    Suit = suit;
            
        //}


        public string RanksOn(Rank rnk)
        {
            string rank = "";

            switch (rnk)
            {
                case Rank.two:
                    rank = "2";
                    break;
                case Rank.three:
                    rank = "3";
                    break;
                case Rank.four:
                    rank = "4";
                    break;
                case Rank.five:
                    rank = "5";
                    break;
                case Rank.six:
                    rank = "6";
                    break;
                case Rank.seven:
                    rank = "7";
                    break;
                case Rank.eight:
                    rank = "8";
                    break;
                case Rank.nine:
                    rank = "9";
                    break;
                case Rank.ten:
                    rank = "10";
                    break;
                case Rank.Jack:
                    rank = "J";
                    break;
                case Rank.Queen:
                    rank = "Q";
                    break;
                case Rank.King:
                    rank = "K";
                    break;
                case Rank.Ace:
                    rank = "A";
                    break;
            }
            //Console.WriteLine($"Chosen rank is {rank}");
            return rank;

        }
        public string SuitsOn(Suit st)
        {
            string suit = "";

            switch (st)
            {
                case Suit.clubs:
                    suit = "♣";
                    break;
                case Suit.diamonds:
                    suit = "♦";
                    break;
                case Suit.hearts:
                    suit = "♥";
                    break;
                case Suit.spades:
                    suit = "♠";
                    break;
            }
            //Console.WriteLine($"Chosen suit is {suit}");
            return suit;

        }
       
    

        public void ShowACard()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Card card = new Card();            
            Console.WriteLine("-----------");
            Console.WriteLine($"|{card.SuitsOn(Suit)}{card.RanksOn(Rank)}       |\n|         |\n|         |\n|         |\n|         |\n|       {card.SuitsOn(Suit)}{card.RanksOn(Rank)}|");
            Console.WriteLine("-----------");            

        }

    }
}
