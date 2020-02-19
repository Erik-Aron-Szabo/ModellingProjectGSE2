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

        public void Round(List<Player> listOfPlayers)
        {
            Comparer comparer = new Comparer();
            // TABLE = List<Card> table
            bool stillGoing = true;
            while (stillGoing)
            {
                foreach (Player player in listOfPlayers)
                {
                    Console.WriteLine("Which attribute do you choose?");
                    Console.WriteLine("(weight), (pushup), (shots)");
                    string ui = Console.ReadLine();
                    if (ui == "weight")
                    {
                        comparer.Compare()
                    }
                    else if (ui == "pushup")
                    {

                    }
                    else if (ui == "shots")
                    {

                    }
                }



                if (true) // a player's Hand = 0 gameOver
                {

                }
            }
        }

        public bool GameNotOver(List<Player> listOfPlayers)
        {
            bool gameOver = true;
            foreach (Player player in listOfPlayers)
            {
                if (player.Hand.Count == 0)
                {
                    gameOver = false;//game is over
                }
            }
            return gameOver;
        }

        public List<Player> GetListOfPlayers()
        {
            Console.WriteLine("How may players are going to play? (2,4,8,16)");
            int numOfPlayers = Int32.Parse(Console.ReadLine());
            List<int> temp = new List<int> { 2, 4, 8, 16 };
            List<Player> listOfPlayers = new List<Player>();
            if (!temp.Contains(numOfPlayers))
            {
                Console.WriteLine("Invalid Input!");
            }

            for (int i = 0; i < numOfPlayers; i++)
            {
                Console.WriteLine("Name of Player: ");
                string name = Console.ReadLine();
                Player player = new Player(name);
                listOfPlayers.Add(player);
            }

            return listOfPlayers;

        }
    }
}
