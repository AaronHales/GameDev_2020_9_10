using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class BaseCard
    {
        protected String rank;
        protected int value;
        protected String suit;
        public static String[] RANKS = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        public static String[] SUITS = { "C", "S", "H", "D" };


        public BaseCard()
        {
            /*
            Console.WriteLine("Begin creating a card by entering in data");
            Console.WriteLine("Enter a rank for you card");
            setRank(Console.ReadLine());
            Console.WriteLine("Enter a suit for the card");
            setSuit(Console.ReadLine());
            setValue();
            */
        }

        public BaseCard(String rank, String suit)
        {

        }

        public void printCard()
        {
            Console.WriteLine("+----------+");
            Console.WriteLine(String.Format("| {0} {1,2}     |", this.suit, this.rank));
            Console.WriteLine("|          |");
            Console.WriteLine("|          |");
            Console.WriteLine("|          |");
            Console.WriteLine("|          |");
            Console.WriteLine("|          |");
            Console.WriteLine("|          |");
            Console.WriteLine(String.Format("|     {0,2} {1} |", this.rank, this.suit));
            Console.WriteLine("+----------+");
        }

        public void setRank(String rank)
        {
            this.rank = rank;
        }

        public void setSuit(String suit)
        {
            this.suit = suit;
        }

        public void setValue()
        {
            if (this.rank.Equals("A"))
            {
                this.value = 1;
            }
            else if (this.rank.Equals("J"))
            {
                this.value = 11;
            }
            else if (this.rank.Equals("Q"))
            {
                this.value = 12;
            }
            else if (this.rank.Equals("K"))
            {
                this.value = 13;
            }
            else
            {
                this.value = int.Parse(this.rank);
            }
        }
    }
    
    public class PosCard : BaseCard 
    {
        private bool pos;

        public PosCard()
        {
            pos = false;
        }

        public PosCard(String rank, String suit)
        {
            this.rank = rank;
            this.suit = suit;
            pos = false;
        }

        public void printCardpos()
        {
            if (pos == true)
            {
                Console.WriteLine("+----------+");
                Console.WriteLine(String.Format("| {0} {1,2}     |", this.suit, this.rank));
                Console.WriteLine("|          |");
                Console.WriteLine("|          |");
                Console.WriteLine("|          |");
                Console.WriteLine("|          |");
                Console.WriteLine("|          |");
                Console.WriteLine("|          |");
                Console.WriteLine(String.Format("|     {0,2} {1} |", this.rank, this.suit));
                Console.WriteLine("+----------+");
            }
            else
            {
                Console.WriteLine("+----------+");
                Console.WriteLine("|xxxxxxxxxx|");
                Console.WriteLine("|xxxxxxxxxx|");
                Console.WriteLine("|xxxxxxxxxx|");
                Console.WriteLine("|xxxxxxxxxx|");
                Console.WriteLine("|xxxxxxxxxx|");
                Console.WriteLine("|xxxxxxxxxx|");
                Console.WriteLine("|xxxxxxxxxx|");
                Console.WriteLine("|xxxxxxxxxx|");
                Console.WriteLine("+----------+");
            }
            
        }

        public void flip()
        {
            if (this.pos == true)
            {
                this.pos = false;
            }
            else
            {
                this.pos = true;
            }
        }

    }

    public class Deck
    {
        private PosCard[] cards = new PosCard[52];

        public Deck()
        {
            this.createDeck();
        }
        public void createDeck()
        {
            int index = 0;
            foreach (String suit in BaseCard.SUITS)
            {
                foreach (String rank in BaseCard.RANKS)
                {
                    PosCard card = new PosCard(rank, suit);
                    cards[index] = card;
                    index++;
                }
            }
            
        }

        public void printDeck()
        {
            int i = 0;
            foreach (PosCard card in cards)
            {
                Console.WriteLine("Card: " + i);
                card.printCardpos();
                card.flip();
                card.printCardpos();
                i++;
                Console.WriteLine("\n\n---------------\n\n\n");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            PosCard card = new PosCard();
            card.printCardpos();
            card.flip();
            card.printCardpos();
            card.flip();
            card.printCardpos();
            Console.ReadLine();
            */

            Deck deck = new Deck();
            deck.printDeck();
            Console.ReadLine();
        }
    }
}
