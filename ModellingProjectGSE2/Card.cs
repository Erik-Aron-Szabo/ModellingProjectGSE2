using System;
using System.Collections.Generic;
using System.Text;

namespace ModellingProjectGSE2
{
    class Card
    {
        private string _name;
        private int _quantity;
        private int _pushup;
        private int _nmrOfShots;
        public Card(string name, int quantity, int pushup, int nmrOfShots)
        {
            _name = name;
            _quantity = quantity;
            _pushup = pushup;
            _nmrOfShots = nmrOfShots;
        }
    }
}
