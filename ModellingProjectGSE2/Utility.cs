using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModellingProjectGSE2
{
    public class Utility
    {
        List<Player> players;
        Player actualPlayer;
        public List<Player> GetPlayers()
        {
            return this.players;
        }
        public void Switch(string ui) //DELEGATE here
        {

        }

        //public void Dealer(List<Player> playerList, List<Card> deck)
        //{
        //    // gives out the 32 cards to a given number of players

        //    while (true)
        //    {
        //        foreach (Player player in playerList)
        //        {
        //            player.
        //        }
        //    }
        //}
        public List<Card> Shuffle(List<Card> deck)
        {
            // May need to rewrite!
            var rnd = new Random();
            List<Card> shuffeledList = deck.OrderBy(a => rnd.Next()).ToList();
            return shuffeledList;
        }
        public void ElementaryDealer(int numberOfPlayers, List<Card> deck)
        {
            if (numberOfPlayers <= 0 || 32 % numberOfPlayers != 0)
            {
                throw new ArgumentException();
            }

            List<Player> players = new List<Player>();

            List<Card> goodDeck = new List<Card>();
            goodDeck = Shuffle(deck);

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("Name of Player: ");
                string name = Console.ReadLine();
                players.Add(new Player(name));

            }
            int dealtCards;
            int nextCard=0;
            int lengthOfName = 0;
            int lengthOfWeight = 0;
            int lengthOfPushup = 0;
            int lengthOfShots = 0;


            for (int i = 0; i < players.Count; i++)
            {
                dealtCards = 0;
                while (dealtCards != goodDeck.Count/players.Count)
                {
                    
                    if (goodDeck[nextCard]._name.Length> lengthOfName)
                    {
                        lengthOfName = goodDeck[nextCard]._name.Length;
                    }
                    if (goodDeck[nextCard]._weight.ToString().Length > lengthOfWeight)
                    {
                        lengthOfWeight = goodDeck[nextCard]._weight.ToString().Length;
                    }
                    
                    if (goodDeck[nextCard]._pushup.ToString().Length > lengthOfPushup)
                    {
                        lengthOfPushup = goodDeck[nextCard]._pushup.ToString().Length;
                    }
                    if (goodDeck[nextCard]._nmrOfShots.ToString().Length > lengthOfShots)
                    {
                        lengthOfShots = goodDeck[nextCard]._nmrOfShots.ToString().Length;
                    }
                    players[i].Hand.Add(goodDeck[nextCard]);
                    dealtCards++;
                    nextCard++;
                }
            }


            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"{players[i].Name} ");
                foreach (Card card in players[i].Hand)
                {
                    Console.WriteLine($"{{0,{lengthOfName+1}}} {{1,{lengthOfWeight+1}}}, {{2,{lengthOfPushup+1}}}, {{3,{lengthOfShots+1}}}",
                        card._name, card._weight,card._pushup,card._nmrOfShots);
                }
            }

        }


    }
}
