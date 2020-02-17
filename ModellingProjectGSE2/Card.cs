using System;
using System.Collections.Generic;
using System.Text;

namespace ModellingProjectGSE2
{
    public class Card
    {
        private string _name;
        private int _weight;
        private int _pushup;
        private int _nmrOfShots;
        public Card(string name, int weight, int pushup, int nmrOfShots)
        {
            _name = name;
            _weight = weight;
            _pushup = pushup;
            _nmrOfShots = nmrOfShots;
        }
    }
}
