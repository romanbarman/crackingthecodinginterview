using Contracts;
using System;

namespace Chapter07.CardDeck
{
    public class Solution : ISolution
    {
        private readonly Deck deck = new Deck();
        private readonly Hand player = new Hand();
        private readonly Hand croupier = new Hand();

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            deck.Shuffle();
            BeginGame();
        }

        private void BeginGame()
        {
            player.Clear();
            croupier.Clear();

            GetCardForPlayer();
            GetCardForPlayer();
            GetCardForCroupier();

            if (player.Score() == BlackJackScoreCounter.BlackJack)
            {
                Console.WriteLine("Player win! 21");
                return;
            }

            PlayerRun();
            CroupierRun();

            if (player.Score() == BlackJackScoreCounter.BlackJack)
            {
                Console.WriteLine("Player win! 21");
                return;
            }

            if (player.Score() > BlackJackScoreCounter.BlackJack)
            {
                Console.WriteLine($"Player lose! {player.Score()}");
                return;
            }

            if (player.Score() > croupier.Score())
            {
                Console.WriteLine($"Player win! {player.Score()} : {croupier.Score()}");
                return;
            }

            if (player.Score() == croupier.Score())
            {
                Console.WriteLine($"Draw! {player.Score()}");
                return;
            }

            Console.WriteLine($"Player lose! {player.Score()} : {croupier.Score()}");
        }

        private void PlayerRun()
        {
            while (player.Score() < 18)
            {
                GetCardForPlayer();
            }
        }

        private void GetCardForPlayer()
        {
            var card = deck.GetCard();
            Console.WriteLine($"Player: {card}");
            player.Add(card);
        }

        private void GetCardForCroupier()
        {
            var card = deck.GetCard();
            Console.WriteLine($"Croupier: {card}");
            croupier.Add(card);
        }

        private void CroupierRun()
        {
            while (croupier.Score() < 17)
            {
                GetCardForCroupier();
            }
        }
    }
}
