using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{

    public class Card
    {
        // Creating a card class to store the rank and suit in each object
        public int rank;
        public string suit;

        public Card(string s)
        {
            //  Breaking up the string to rank and suit
            suit = s.Substring(s.Length - 1);
            string temp = s.Substring(0, s.Length - 1);
            
            // converting the face cards to numbered ranks
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
    public class PokerCards
    {
        public List<Card> cards = new List<Card>();
        public int[] cardRanks = new int[15];
        public void SortRanks()
        {
            // This function is used sort the ranks - used further in sequencing
            cards.Sort((x1, x2) => x1.rank.CompareTo(x2.rank));
        }

        public bool SameSuits()
        {
            // This function check if the suits of given cards are same
            return (cards.All(x => x.suit == cards[0].suit));
        }

        public bool SameRanks()
        {
            // This function check all ranks are same
            return (cards.All(x => x.rank == cards[0].rank));
        }

        public bool Sequence()
        {
            // This function used to check Sequence by sorting the ranks first
            SortRanks();
            for(int i=0;i<cards.Count-1;i++)
            {
                if (cards[i].rank + 1!= cards[i+1].rank)
                {
                    return false;
                }
            }
            return true;
        }

        public void GetRanks()
        {
            // This function used to store the ranks and their count in that respective rank index
            foreach (var card in cards)
            {
                cardRanks[card.rank] += 1;
            }
        }
        public bool NOfaKind(int count)
        {
            // Takes input count and check if count no of cards or of same kind using ranks
            return Array.Exists(cardRanks, x => x >= count);
        }
        public bool TwoPairs()
        {
            // Checks if there are two different paris using cardRanks
            return Array.FindAll(cardRanks, x => x >= 2).Length == 2;
        }
        public bool FullHouse()
        {
            // Checks if there are two diffrent kinds of pairs 
            return Array.Exists(cardRanks, x => x == 3) && Array.Exists(cardRanks, x => x ==2); ;
        }
        public void PokerHandRanking()
        {
            // checks all the conditions and prints the results
            bool anyCondition = false;
            if (Sequence() && cards.ElementAt(0).rank == 10 && SameSuits())
            {
                anyCondition = true;
                Console.WriteLine("Royal Flush");
            }
            if (Sequence() && SameSuits())
            {
                anyCondition = true;
                Console.WriteLine("Straight Flush");
            }
            if(NOfaKind(4))
            {
                anyCondition = true;
                Console.WriteLine("four of a kind");
            }
            if(NOfaKind(3))
            {
                anyCondition = true;
                Console.WriteLine("three of a kind");
            }
            if(FullHouse())
            {
                anyCondition = true;
                Console.WriteLine("Full house");
            }
            if(NOfaKind(2))
            {
                anyCondition = true;
                Console.WriteLine("Pair");
            }
            if(!Sequence() && SameSuits())
            {
                anyCondition = true;
                Console.WriteLine("Flush");
            }
            if (Sequence() && !SameSuits())
            {
                anyCondition = true;
                Console.WriteLine("Straight");
            }
            if(TwoPairs())
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
            PokerCards p = new();

            //user defined input 
            Console.WriteLine("Enter 5 cards by giving spaces");
            string[] cardUserInput = Console.ReadLine().Split(' ');
            string[] cardInput = { "10s", "10c", "8d", "10d", "10h" };//{ "6s", "6h", "6d", "Kc", "Kh" };
            // { "3h", "5h", "Qs", "9h", "Ad" };//{ "10h", "Jh", "Qh", "Ah", "Kh" };
            foreach (string card in cardInput)
            {
                Card temp = new Card(card);
                p.cards.Add(temp);
            }
            
            p.GetRanks();              // Initializes the cardRanks list - increments the respective rank
            p.PokerHandRanking();
        }
    }
}

