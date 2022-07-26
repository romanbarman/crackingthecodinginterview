using Contracts;
using System.Collections.Generic;

namespace Chapter07
{
    public class Q7_01_Card_Deck : BaseQuestion
    {
        private static readonly ISolution[] solutions = new ISolution[]
        {
            new CardDeck.Solution()
        };

        public override string GetDescription()
        {
            return "Design data structures for a universal deck of cards. How to subclass to implement the game of blackjack.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
