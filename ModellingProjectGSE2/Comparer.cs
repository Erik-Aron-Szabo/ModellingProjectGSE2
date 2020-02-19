using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ModellingProjectGSE2
{
    public class Comparer : IComparer<Card>
    {
        int IComparer<Card>.Compare(Card x, Card y)
        {
            throw new NotImplementedException();
        }
        
        public Comparer()
        {

        }
        public int PushupCompare([AllowNull] Card a, [AllowNull] Card b)
        {

            if (a._pushup > b._pushup)
            {
                return 1;
            }
            else if (a._pushup < b._pushup)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
        public int ShotsCompare([AllowNull] Card a, [AllowNull] Card b)
        {

            if (a._nmrOfShots > b._nmrOfShots)
            {
                return 1;
            }
            else if (a._nmrOfShots < b._nmrOfShots)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
        public int WeightCompare([AllowNull] Card a, [AllowNull] Card b)
        {
            if (a._weight > b._weight)
            {
                return 1;
            }
            else if (a._weight < b._weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }
}
