using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Card
    {
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
            Console.WriteLine($"Chosen rank is {rank}");
            return rank;

        }

    }
}
