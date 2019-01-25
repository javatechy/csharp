using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectA.TeamA
{
    public class Customer
    {
        string FirstName;
        string LastName;

        // bcoz default constructor must be definded in case using parameterizaed constructor
        public Customer() : this("No First Name", " No Last Name") {
            // error : 
            //this("No First Name", " No Last Name");
        }
        public Customer(string FirstName , string LastName) {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public void printName()
        {
            Console.WriteLine("Full Name  : {0}", this.FirstName + this.LastName);
         
        }

        ~Customer() {

            Console.WriteLine("Destructor");
        }
    }
}
