using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_04.Youtube
{
    internal class Subscriber
    {

        public string SubscriberName { get; set; }

        public void Notify(Video video , Channel channel)
        {
            Console.WriteLine(value: $"{channel.ChannelName} New Video Has Been Added!! , {SubscriberName} , \n {video} \n\n");
        }


        public override string ToString()
        {
            return $" Subscriber Name: {SubscriberName}";
        }
    }
}
