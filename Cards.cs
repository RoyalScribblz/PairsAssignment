using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace PairsAssignment
{
    public static class Cards
    {
        public static readonly List<Image> AllCards = new();
        private static readonly Random Random = new();

        /// <summary>Pseudo-random list of image identifiers.</summary>
        /// <param name="amount">Number of cards to be returned.</param>
        /// <returns>Un-shuffled list of integer identifiers.</returns>
        private static IEnumerable<int> GetRandomCards(int amount)
        {
            List<int> randomCards = new();
            
            while (amount >= 54)
            {
                for (int i = 0; i < 54; i++) randomCards.Add(i);  // add card index 0-53 to the list
                amount -= 54;
            }
            for (int i = 0; i < amount; i++) randomCards.Add(Random.Next(0, 54));  // add random 0-53 to the list
            
            return randomCards;
        }

        /// <summary>Gets a list of integer identifiers of a given amount of cards.</summary>
        /// <param name="amount">The amount of cards, NOT number of pairs.</param>
        /// <param name="arraySize">Width and height of the returned array.</param>
        /// <returns>A shuffled list of card pairs.</returns>
        public static int[,] GetRandomPairs(int amount, int arraySize)
        {
            List<int> randomCards = new();
            foreach (int randomCard in GetRandomCards(amount / 2))
            {
                randomCards.Add(randomCard);
                randomCards.Add(randomCard);
            }

            List<int> shuffledList = ShuffleCardList(randomCards);
            int[,] randomPairs = new int[arraySize, arraySize];
            int counter = 0;
            for (int row = 0; row < arraySize; row++)
            {
                for (int column = 0; column < arraySize; column++)
                {
                    randomPairs[row, column] = shuffledList[counter];
                    counter++;
                }
            }
            return randomPairs;
        }

        /// <summary>Shuffle cards to be in a random order.</summary>
        /// <param name="cardList">Collection of cards to be shuffled.</param>
        /// <returns>Shuffled collection of cards.</returns>
        private static List<int> ShuffleCardList(IEnumerable<int> cardList)
        {
            return cardList.OrderBy(_ => Random.Next()).ToList();
        }
    }
}