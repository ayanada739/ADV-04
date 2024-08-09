 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_04.Game
{
    internal class Ball
    {
        public int Id { get; set; }

        private Location location;

        public Location Location
        {
            get { return location; }
            //Event
            set
            {

                if(!value.Equals( location))
                {
                    location = value;
                    //Notify Subscriber
                    BallLocationChanged?.Invoke();

                }
                
            }
        }

        //Event
        public event Action? BallLocationChanged;

        public override string ToString()
        {
            return $"Id: {Id} , Location: {Location}";
        }
    }
}
