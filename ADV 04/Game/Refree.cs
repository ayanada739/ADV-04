using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_04.Game
{
    internal class Refree
    {
        public string RefreeName { get; set; }

        //Call Back Function
        public void Look()
        {
            Console.WriteLine(value: $"Refree: {RefreeName} is looking At Ball");
        }
    }
}
