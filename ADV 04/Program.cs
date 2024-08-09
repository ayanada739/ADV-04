using ADV_04.Game;
using ADV_04.Youtube;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Channels;

namespace ADV_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Event Ex01
            //Ball ball = new Ball() { Id = 1};

            //Console.WriteLine(ball);

            //ball.Location = new Location() { X = 1, Y = 1, Z = 1 };

            //Console.WriteLine(ball);


            //Player P01 = new Player() { PlayerName = "Messi", TeamName = "Miami" };
            //Player P02 = new Player() { PlayerName = "Alba", TeamName = "Miami" };

            //Player P03 = new Player() { PlayerName = "Pedri", TeamName = "Barcelona" };
            //Player P04 = new Player() { PlayerName = "Gavi", TeamName = "Barcelona" };

            //Player P05 = new Player() { PlayerName = "MoSalah", TeamName = "Liverbol" };


            //Refree R01 = new Refree() { RefreeName = "Ibrahim Nour El-Din" };

            //ball.Location = new Location() { X = 1, Y = 1, Z = 1 };

            //ball.BallLocationChanged += P01.Run;
            //ball.BallLocationChanged += P02.Run;
            //ball.BallLocationChanged += P03.Run;
            //ball.BallLocationChanged += P04.Run;
            //ball.BallLocationChanged += R01.Look;

            //ball.Location = new Location() { X = 1, Y = 1, Z = 2 };

            //Console.WriteLine(value: "\n After Pedri Changed With MoSalah \n");

            //ball.BallLocationChanged -= P03.Run;
            //ball.BallLocationChanged += P05.Run;

            //ball.Location = new Location() { X = 1, Y = 1, Z = 3 }; 
            #endregion

            #region Event Ex02
            //Channel channel = new Channel() { ChannelName = "ABC" };

            //channel.AddVideo(video: new Video() { Title = "Title01", Description = "Desc01" });

            //Subscriber S01 = new Subscriber() { SubscriberName = "Ahmed" };
            //Subscriber S02 = new Subscriber() { SubscriberName = "Ali" };
            //Subscriber S03 = new Subscriber() { SubscriberName = "Sami" };
            //Subscriber S04 = new Subscriber() { SubscriberName = "Aya" };
            //Subscriber S05 = new Subscriber() { SubscriberName = "Mai" };


            //channel.UploadVideo += S01.Notify;
            //channel.UploadVideo += S02.Notify;
            //channel.UploadVideo += S03.Notify;
            //channel.UploadVideo += S04.Notify;


            //channel.AddVideo(video: new Video() { Title = "Title02", Description = "Desc02" });


            //Console.WriteLine(value: "after Sami Cancel");
            //Console.WriteLine(value: "after  add Mai");

            //channel.UploadVideo -= S03.Notify;
            //channel.UploadVideo += S05.Notify; 
            #endregion

            //Collection: Built -in DS In C#
            //Lists
            //Hashtables

            //Non—Generics Collection
            //Generic Collection


            //Lists
            //Non—Generics: Arraylist
            //Generics Collection: List - LinkedList - Stack— Queue



            //Hashtables:
            //Non—Generics Collection :Hashtables
            //Generic Collection:



        }
    }
}
