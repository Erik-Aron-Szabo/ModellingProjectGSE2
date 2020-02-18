using System;
using System.Collections.Generic;
using System.Text;

namespace ModellingProjectGSE2
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand {get; set;}


        public Player(string name, List<Card> hand)
        {
            this.Name = name;
            this.Hand = hand;
        }
        public Player(string name)
        {
            this.Name = name;
            this.Hand = new List<Card>();
        }

        public Player()
        {

        }

    }
}
