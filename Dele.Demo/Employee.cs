using System;
using System.Collections.Generic;
using System.Text;

// Ref http://csharp-video-tutorials.blogspot.com/2012/06/part-38-c-tutorial-delegates-example-ii.html 
namespace Dele.Demo
{
   public delegate bool IsPromotableDelegate(Employee emp);

   public class Employee
    {

        public int Id { get; set; }
        
        public string Name { get; set; }

        public int Salary { get; set; }

        public int Experience { get; set; }

        public static void PromoteEmployess(List<Employee> emplList, IsPromotableDelegate isPromotable)
        {
            foreach (Employee emp in emplList)
            {
                if (isPromotable(emp)) {
                    Console.WriteLine(emp.Name + "is promoted");
                }
            }
        }
    }
}
