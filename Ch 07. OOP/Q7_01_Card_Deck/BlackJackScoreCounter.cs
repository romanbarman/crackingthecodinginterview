using System;
using System.Collections.Generic;

namespace Chapter07.CardDeck
{
    public class BlackJackScoreCounter
    {
        public const int BlackJack = 21;

        public int CountScore(IList<Card> cards)
        {
            var score1 = 0;
            var score2 = 0;

            foreach (var card in cards)
            {
                var scores = GetScores(card.Value);
                score1 += scores.score1;
                score2 += scores.score2;
            }

            if (score1 == BlackJack || score2 == BlackJack)
            {
                return BlackJack;
            }

            if (score1 > BlackJack && score2 > BlackJack)
            {
                return Math.Min(score1, score2);
            }

            if (score1 > BlackJack && score2 < BlackJack)
            {
                return score2;
            }

            if (score2 > BlackJack && score1 < BlackJack)
            {
                return score1;
            }

            return Math.Max(score1, score2);
        }

        private (int score1, int score2) GetScores(Value value) => value switch
        {
            Value.Ace => (11, 1),
            Value.Two => (2, 2),
            Value.Three => (3, 3),
            Value.Four => (4, 4),
            Value.Five => (5, 5),
            Value.Six => (6, 6),
            Value.Seven => (7, 7),
            Value.Eight => (8, 8),
            Value.Nine => (9, 9),
            _ => (10, 10)
        };
    }
}
