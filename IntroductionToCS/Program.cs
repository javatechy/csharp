﻿using System;
using CUST = ProjectA.TeamA;
using DEL = Dele.Demo;

using System.Collections.Generic;

using Collections;

namespace IntroductionToCS
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------List----------------------------------------------");
            ListTest.Main();
            Console.WriteLine("-------------------------------------------Dictionary----------------------------------------------");
            DictionaryTest.Main();
            Console.WriteLine("-------------------------------------------Delegates----------------------------------------------");
            DEL.DelegateTest.Delegates();
            Console.WriteLine("----------------------------------------------TypeTesting------------------------------------------");
            TypeTesting();
            CUST.ClassA.Print();
            CallCustomer();
            Console.WriteLine("----------------------------------------------Inhertience------------------------------------------");
            Inhertience();
            Console.WriteLine("----------------------------------------------Properties------------------------------------------");
            PropertiesTest();
           
            
        }


        public static void TypeTesting()
        {
            int? ui = null;

            Console.WriteLine("hello {0}", ui);

            float f = 123534789057348957348955.23f;
            int i = (int)f;
            Console.WriteLine("Hello World!" + i);


            string num = "10076482374892374823742389472389472389";
            int n = 0;
            int.TryParse(num, out n);

            Console.WriteLine("Hellonumber !" + n);


        }


        public static void PropertiesTest()
        {
            Properties.PreopertyTest pt = new Properties.PreopertyTest();
            Console.WriteLine("Hellonumber !" + pt.EmailId);
            pt.Id = -1000;
        }

        public static void CallCustomer()
        {
            CUST.Customer custeom = new CUST.Customer("Deepak", "Kumar");
            custeom.printName();
        }


        public static void Inhertience()
        {
            CUST.ChildClass cc = new CUST.ChildClass();
        }
    }
}
