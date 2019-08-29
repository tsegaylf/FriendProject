using System;
using System.Collections.Generic;
using System.Text;

namespace FriendProject {
    class Friend {

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool BFF { get; set; } = false;
        public int HowLong { get; set; } 


        public Friend(string name, string phone, string email, bool bff, int howlong) { // create default constructor
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.BFF = bff;
            this.HowLong = howlong;
        }

        public Friend() { // default constructor
                }

        //int 1 =0;
        //i.ToString();
        //bool b = true;
        //bool.ToString

        public override string ToString() {
            return $"{Name, -15} {Phone, -12} {Email, -25} {(BFF ? "BFF" : ""), 3} {HowLong}"; //Interpolation string
        }

        // set to 10 if BFF and set to 0 if not BFF --- did a TERNARY operation in program.cs
    
       





    }
}
