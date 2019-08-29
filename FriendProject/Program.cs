using System;

namespace FriendProject {
    class Program {
        static void Main(string[] args) {

            var F1 = new Friend("Chiamaka", "513-456-3456", "chi@gmail.com", true, 3);
            var F2 = new Friend("Yohanna", "413-456-3456", "yoh@gmail.com", true, 2);
            var F3 = new Friend("Abel", "613-456-3456", "abel@gmail.com", true, 5);
            var F4 = new Friend("Erica", "613-456-3456", "erica@gmail.com", false, 1);
            var F5 = new Friend("Ashley", "713-456-3456", "ash@gmail.com", false, 4);

            var friends = new Friend[] { F1, F2, F3, F4, F5};

             foreach (var friend in friends) {
                Console.WriteLine(friend);
                }
        





        }
    }
}
