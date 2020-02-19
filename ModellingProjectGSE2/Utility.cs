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
            int lengthOfName_char = 0;

            for (int i = 0; i < players.Count; i++)
            {
                dealtCards = 0;
                while (dealtCards != goodDeck.Count/players.Count)
                {
                    
                    if (goodDeck[nextCard]._name.Length> lengthOfName_char)
                    {
                        lengthOfName_char = goodDeck[nextCard]._name.Length;
                    }
                    /*
                    if (goodDeck[nextCard]._weight.Length > lengthOfName_char)
                    {
                        lengthOfName_char = goodDeck[nextCard]._name.Length;
                    }
                    if (goodDeck[nextCard]._name.Length > lengthOfName_char)
                    {
                        lengthOfName_char = goodDeck[nextCard]._name.Length;
                    }
                    if (goodDeck[nextCard]._name.Length > lengthOfName_char)
                    {
                        lengthOfName_char = goodDeck[nextCard]._name.Length;
                    }
                    */
                    players[i].Hand.Add(goodDeck[nextCard]);
                    dealtCards++;
                    nextCard++;
                }
            }
            Console.WriteLine(lengthOfName_char);
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"P{(i+1)} ");
                foreach (Card card in players[i].Hand)
                {
                    //Console.WriteLine($"{{0,{lengthOfName_char}}} {card._weight,4}", card._name);
                    Console.WriteLine($"{card._name,17}, {card._weight,4}, {card._pushup,4}, {card._nmrOfShots,3}  ");
                }
            }
        }


    }
}
