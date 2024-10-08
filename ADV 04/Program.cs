﻿using ADV_04.Game;
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


            #region HashTable
            //Hashtable Note = new Hashtable();

            //Console.WriteLine(value: $"Count: {Note.Count}");

            //Note.Add(key: "Ahmed", value: 999999);
            //Note.Add(key: "'Ali", value: 8888888);
            //Note.Add(key: "Omar", value: 7777777);
            //Console.WriteLine(value: $"Count: {Note.Count}");

            //foreach (object item in Note.Values)
            //  {
            //Console.WriteLine(item);

            // }

            //Note[ "Ahmed"] = 111111;

            //Note[key: "Hamada"] = 12; //Set Get

            //Console.WriteLine(Note[key: "Ahmed"]);

            //Note.Add(key: "Ahmed", value: 7777777);
            //Note.Add(null, 7777777);

            //Note.Remove(null); 


            //Console.WriteLine();
            //Console.WriteLine(value: "======= Item of Hashtable: =====");
            //foreach (DictionaryEntry item in Note)
            //{
            //    Console.WriteLine(value: $"key: {item.Key} value: {item.Value}");

            //}

            //O(n^2)
            //O(n)
            //O(n*Log(n))
            //O(Log(n))
            //O(Log(n))

            #endregion



            #region  Generic Collection - Dictionary
            // Generic Version Of The Hashtable : Dictionary

            //Dictionary<string, long> Note = new Dictionary<string, long>();

            //Note.Add(key: "Ahmed", value: 999999);
            //Note.Add(key: "Mohamed", value: 999999);
            //Note.Add(key: "Ali", value: 888888);
            //Note.Add(key: "Omar", value: 777777);

            //100
            //Note.EnsureCapacity(120);
            //Note.TryGetValue(key: "Ahmed", out long result); //0

            //foreach (KeyValuePair<string , long> item in Note)
            //{
            //    Console.WriteLine(value: $"Key: {item.Key}, Value: {item.value}");
            //}

            #endregion


        }
    }
}
