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
        List<Card> goodDeck;
        public void Switch(string ui) //DELEGATE here
        {

        }

        public void ElementaryDealer(List<Card> deck)
        {
            goodDeck = Shuffle(deck);
            Console.WriteLine("How many players are going to play? ( 2, 4, 8, 16, 32)");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            players = GetListOfPlayers(numberOfPlayers);
            Console.Clear();


        }
        public List<Card> Shuffle(List<Card> deck)
        {
            var rnd = new Random();
            List<Card> shuffeledList = deck.OrderBy(a => rnd.Next()).ToList();
            return shuffeledList;
        }
        public void Round(List<Player> listOfPlayers)
        {
            // TABLE = List<Card> table
            bool stillGoing = true;
            Comparer comparer = new Comparer();
            while (stillGoing)
            {
                foreach (Player player in listOfPlayers)
                {
                    Console.WriteLine("Which attribute do you choose?");
                    Console.WriteLine("(weight), (pushup), (shots)");
                    string ui = Console.ReadLine();
                    if (ui == "weight")
                    {
                        comparer.WeightCompare(player.Hand[0], player.Hand[0]);
                    }
                    else if (ui == "pushup")
                    {
                        comparer.PushupCompare(player.Hand[0], player.Hand[0]);

                    }
                    else if (ui == "shots")
                    {
                        comparer.ShotsCompare(player.Hand[0], player.Hand[0]);

                    }
                }
                GameNotOver(players);
            }
        }
        public List<Player> GetListOfPlayers(int n)
        {
            List<Player> listOfPlayers = new List<Player>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Name of Player"+(i+1)+": ");
                string name = Console.ReadLine();
                Player player = new Player(name);
                listOfPlayers.Add(player);
            }
            return listOfPlayers;

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
        public void NiceCLIWriter()
        {
            int dealtCards;
            int nextCard = 0;
            int lengthOfName = 0;
            int lengthOfWeight = 0;
            int lengthOfPushup = 0;
            int lengthOfShots = 0;


            for (int i = 0; i < players.Count; i++)
            {
                dealtCards = 0;
                while (dealtCards != goodDeck.Count / players.Count)
                {

                    if (goodDeck[nextCard]._name.Length > lengthOfName)
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
                    Console.WriteLine($"{{0,{lengthOfName + 1}}} {{1,{lengthOfWeight + 1}}}, {{2,{lengthOfPushup + 1}}}, {{3,{lengthOfShots + 1}}}",
                        card._name, card._weight, card._pushup, card._nmrOfShots);
                }
            }
        }

    }
}
