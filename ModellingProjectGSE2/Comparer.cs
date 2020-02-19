using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ModellingProjectGSE2
{
    public class Comparer : IComparer<Card>
    {
        public  
        public Card Compare(Card a, Card b)
        {
            Console.WriteLine("Attribute: ");
            Console.WriteLine("weight or pushup or shots");
            string attribute = Console.ReadLine();
            Card none = new Card();

            if (attribute == "weight")
            {
                if (a._weight > b._weight)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }

            else if (attribute == "pushup")
            {
                if (a._pushup > b._pushup)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }

            else if (attribute == "shots")
            {
                if (a._nmrOfShots > b._nmrOfShots)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
            return none;
        }

        public int Compare([AllowNull] Card x, [AllowNull] Card y)
        {
            throw new NotImplementedException();
        }

        public Comparer()
        {

        }
    }
}
