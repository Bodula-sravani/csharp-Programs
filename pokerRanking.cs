using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{

    public class Card
    {
        public int rank;
        public string suit;


        public Card(string s)
        {
            suit = s.Substring(s.Length - 1);
            string temp = s.Substring(0, s.Length - 1);
            
            if (temp == "A")
            {
                rank = 14;
            }
             else if (temp == "J")
            {
                rank = 11;
            }
             else if (temp == "Q")
            {
                rank = 12;
            }
             else if (temp == "K")
            {
                rank = 13;
            }
            else 
            {
                rank = Convert.ToInt32(temp);
            }

        }


    }
    public class pokerRanking
    {
        public List<Card> cards = new List<Card>();
        public List<char> suits = new List<char>() { 'c', 'h', 's', 'd' };
        public int[] cardRanks = new int[15];


        public void sortRank(List<Card> cards1)
        {
            cards1.Sort((x1, x2) => x1.rank.CompareTo(x2.rank));
            //return cards1;
        }

        public bool sameSuits(List<Card> cards1)
        {

            return (cards1.All(x => x.suit == cards1[0].suit));

        }
        public bool sameRanks(List<Card> cards1)
        {
            return (cards1.All(x => x.rank == cards1[0].rank));
        }


        public bool sequence(List<Card> cards1)
        {
            sortRank(cards1);
            for(int i=0;i<cards1.Count-1;i++)
            {
                if (cards1[i].rank + 1!= cards1[i+1].rank)
                {
                    return false;
                }
            }
            return true;
        }

        public bool straightFlush()
        {
            return sequence(cards) && sameSuits(cards);
        }
        public bool royalFlush()
        {
            return sequence(cards) && cards.ElementAt(0).rank == 10 && sameSuits(cards);
        }
        public void getRanks()
        {
            foreach(var card in cards)
            {
                cardRanks[card.rank] += 1;
            }
            foreach(int i in cardRanks)
            {
                Console.WriteLine(i);
            }
        }
        public bool nOfaKind(int count)
        {
            //getRanks();
            return Array.Exists(cardRanks, x => x >= count);
        }
        public bool twoPairs()
        {
            //getRanks();
            return Array.FindAll(cardRanks, x => x >= 2).Length == 2;
        }
        public bool fullHouse()
        {
            return Array.Exists(cardRanks, x => x == 3) && Array.Exists(cardRanks, x => x ==2); ;
        }
        public void pokerHandRanking()
        {
                  bool anyCondition = false;
                  if(royalFlush())
                    {
                        anyCondition = true;
                        Console.WriteLine("Royal Flush");
                    }
                  if(straightFlush())
                    {
                        anyCondition = true;
                        Console.WriteLine("Straight Flush");
                    }
                  if(nOfaKind(4))
                    {
                        anyCondition = true;
                        Console.WriteLine("four of a kind");
                    }
                  if(nOfaKind(3))
                    {
                        anyCondition = true;
                        Console.WriteLine("three of a kind");
                    }
                  if(fullHouse())
                    {
                         anyCondition = true;
                        Console.WriteLine("Full house");
                    }
                  if(nOfaKind(2))
                    {
                        anyCondition = true;
                        Console.WriteLine("Pair");
                    }
                 if(!sequence(cards) && sameSuits(cards))
                    {
                        anyCondition = true;
                        Console.WriteLine("Flush");
                    }
                  if (sequence(cards) && !sameSuits(cards))
                    {
                        anyCondition = true;
                        Console.WriteLine("Straight");
                    }
                  if(twoPairs())
                    {
                     anyCondition = true;
                    Console.WriteLine("Two different pair");
                    }
                if(!anyCondition)
                {
                    Console.WriteLine("High card");
                }

        }
        public static void Main()
        {
            pokerRanking p = new();
            //Console.WriteLine("Enter 5 cards by giving spaces");
            //string[] cardInput = Console.ReadLine().Split(' ');
            string[] cardInput = { "6s", "6h", "6d", "Kc", "Kh" };//{ "10s", "10c", "8d", "10d", "10h" };// { "3h", "5h", "Qs", "9h", "Ad" };//{ "10h", "Jh", "Qh", "Ah", "Kh" };
            foreach (string card in cardInput)
            {
                Card temp = new Card(card);
                p.cards.Add(temp);
            }
            p.getRanks();
            //Console.WriteLine(p.cards.Count);
            p.pokerHandRanking();
        }
    }
}

