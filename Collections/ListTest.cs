using System;
using System.Collections.Generic;

namespace Collections
{
    public class ListTest
    {

        public static void Main() {
            Customer demo = new Customer { Id =1, Name ="Deepak"};

            var list = new List<Customer>();
            list.Add(new Customer { Id = 2, Name = "Pr" });

            list.Add(demo);

            if(list.Exists(cust=> cust.Name.Equals("Deepak"))){

                Console.WriteLine("Hey Deepak is presetn in the list");
            }

            // its a Delegate
            Comparison<Customer> customerComaprison = new Comparison<Customer>(CustComparison);

            foreach (var cust in list)
            {
                Console.WriteLine("Cust print list : " + cust.Name);
            }

         //   list.Sort(customerComaprison);

            list.Sort((c1, c2)=> c1.Name.CompareTo(c2.Name));

            foreach (var cust in list) {
                Console.WriteLine("Cust print list : "+ cust.Name);
            }

        }

        private  static int CustComparison(Customer c1, Customer c2) {
            return c1.Name.CompareTo(c2.Name);
        }
    }

}
