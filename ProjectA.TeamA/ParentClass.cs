using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectA.TeamA
{
   public class ParentClass
    {

        public ParentClass() {
            Console.WriteLine("parent class Constructor Called");
        }

        public ParentClass(string message) {
            Console.WriteLine(message);
        }
    }


    public class ChildClass : ParentClass {

        public ChildClass() : base("Derived calass controlling parent class")
        {
            Console.WriteLine("child Class constructor");
        }
    }
}
