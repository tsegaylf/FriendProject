using System;
using System.Collections.Generic;

namespace FriendProject {
    class Program {
        static void Main(string[] args) {

            //List<int> integers = new List<int>();
            //integers.Add(17);//how to add to the list 
            //integers.Add(0);
            //integers.Add(88);
            //integers.Add(43);
            //var count = integers.Count; //to find out how many items are in the collection
            //integers.Sort(); // this can't e done with a fixed array 
            //integers.Remove(0); //you can also remove items

            var f1 = new Friend("Chiamaka", "513-456-3456", "chi@gmail.com", true, 16);
            var f2 = new Friend("Yohanna", "413-456-3456", "yoh@gmail.com", true, 7);
            var f3 = new Friend("Abel", "613-456-3456", "abel@gmail.com", true, 18);
            var f4 = new Friend("Erica", "613-456-3456", "erica@gmail.com", false, 5);
            var f5 = new Friend("Ashley", "713-456-3456", "ash@gmail.com", false, 4);

            //var friends = new Friend[] { f1, f2, f3, f4, f5};
            var friends = new List<Friend>();
            friends.Add(f1);
            friends.Add(f2);
            friends.Add(f3);
            friends.Add(f4);
            friends.Add(f5);

            var aFriend = friends[0];

            foreach (var friend in friends) {
                friend.HowLong = (friend.BFF) ? 10 : 0;
                Console.WriteLine(friend);
                }

            Dictionary<string, string> StateCodes = new Dictionary<string, string>();/// same as var StateCodes = new Dictionary<string, string>();
            StateCodes.Add("OH", "Ohio");
            StateCodes.Add("KY", "Kentucky");
            StateCodes.Add("IN", "Indiana");
            StateCodes.Add("CA", "California");
            var ohio = StateCodes["OH"];
            




        }
    }
}
