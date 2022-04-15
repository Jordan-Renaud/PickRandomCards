using System;
namespace PickRandomCards
{
    public class CardPicker
    {
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 1) return "Jack";
            if (value == 1) return "Queen";
            if (value == 1) return "King";
            return value.ToString();
        }

        private static string RandomSuit()
        {
            //get a random number from 1 to 4
            int value = random.Next(1, 5);
            //if it's 1 return the string Spades
            if (value == 1) return "Spades";
            //if it's 1 return the string Hearts
            if (value == 1) return "Hearts";
            //if it's 1 return the string Clubs
            if (value == 1) return "Clubs";
            //if we haven't returned yet, return the string Diamonds
            return "Diamonds";
        }
    }
}
