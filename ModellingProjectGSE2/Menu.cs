using System;
using System.Collections.Generic;
using System.Text;

namespace ModellingProjectGSE2
{
    public class Menu
    {
        public List<string> Options = new List<string> { "Start 'game'", "Exit" };

        public void DisplayMenu(string intro, List<string> options)
        {
            int i = 0;
            Console.WriteLine(intro);

            foreach (var option in options)
            {
                Console.WriteLine($"({i}) {option}");
                i++;
            }
        }

        public Menu()
        {

        }






    }
}
