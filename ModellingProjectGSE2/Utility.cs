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
            List<Card> shuffeledList = deck.OrderBy(a => Guid.NewGuid()).ToList();
            return shuffeledList;
        }
        public void ElementaryDealer(int numberOfPlayers, List<Card> deck)
        {
            if (numberOfPlayers <= 0 || 32 % numberOfPlayers != 0)
            {
                throw new ArgumentException();
            }

            List<Player> players = new List<Player>();
            Shuffle(deck);

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("Name of Player: ");
                string name = Console.ReadLine();
                players.Add(new Player(name));

            }
            int r = deck.Count;
            int j = 0;
            while (r!=j)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    players[i].Hand.Add(deck[j]);
                    deck.RemoveAt(0);
                    //sanyi itt j'rt tegnap
                }
            }


            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"P{(i+1)} ");
                foreach (Card card in players[i].Hand)
                {
                    Console.WriteLine($"{card._name}, {card._pushup}, {card._nmrOfShots}, ");
                }
            }
        }


    }
}
