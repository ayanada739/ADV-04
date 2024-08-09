using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_04.Game
{
    internal class Player
    {
        public string PlayerName { get; set;}

        public string TeamName { get; set;}

        //Call Back Function
        public void Run()
        {
              Console.WriteLine(value: $"Player: {PlayerName} is Running .....");
        }





    }
}
