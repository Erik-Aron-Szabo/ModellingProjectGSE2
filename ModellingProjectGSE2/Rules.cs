using System;
using System.Collections.Generic;

namespace ModellingProjectGSE2
{
    public class Rules
    {
        
        public void HandSizeCheck()
        {
            Utility utility = new Utility();
            foreach (Player player in utility.GetPlayers())
            {
                if (player.Hand.Count==0)
                {
                    
                }
            }
        }
        






    }
}
