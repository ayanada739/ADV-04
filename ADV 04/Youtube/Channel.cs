using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_04.Youtube
{
    internal class Channel
    {
        public string ChannelName { get; set; } //ABC
        public List<Video> Videos { get; set; } = new List<Video>();
        public void AddVideo (Video video)
        {
            Videos.Add(video);

            //Notify Subscriber
            UploadVideo?.Invoke(video , this );
        }

        public event Action<Video , Channel >? UploadVideo;
             

        public override string ToString()
        {
            return $"Channel Name: {ChannelName}";
        }
    }
}
