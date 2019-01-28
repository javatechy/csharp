using System;
using System.Collections.Generic;

namespace Collections
{
    public class DictionaryTest
    {

        public static void Main() {
            Customer demo = new Customer { Id =1, Name ="Deepak "};

            var dictionary = new Dictionary<int, Customer>();

            dictionary.Add(1, demo);
            dictionary.Add(2, demo);


            //bool isPreset = dictionary.TryGetValue(1);

            // throws Execption if 1 key is not preeset
            Console.WriteLine("Dictionary Name at " + dictionary[1].Name);

            // or use var
            foreach(KeyValuePair<int, Customer> keyVal in dictionary)
            {
                Console.WriteLine("Dictionary Key :  " + keyVal.Key);
                Console.WriteLine("Dictionary Value :  " + keyVal.Value.Name);
            }



            if (dictionary.ContainsKey(1))
            {

                Console.WriteLine("Key 1 is already present");
            }

            Customer cust;
            if (dictionary.TryGetValue(11,out cust))
            {
                Console.WriteLine("TryGetValue Successful Value :  " + cust.Name);
            }
            else {
                Console.WriteLine("TryGetValue says : Key Not found :  ");
            }

            Console.WriteLine("Totoal items :  " + dictionary.Count);

            Console.WriteLine("Totoal items with id =1 :  " + dictionary.Count);
        }
    }


    internal class Customer { 
    
        public int Id {
            get;
            set;
        }
        public string Name {
            get;
            set;
        }
    }
}
