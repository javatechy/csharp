using System;
using System.Collections.Generic;
using System.Text;


namespace Dele.Demo
{
   public class DelegateTest
    {
        public static void Delegates()
        {
            HelloFunctionDelegate dele = new HelloFunctionDelegate(Delegate.hello);

            dele("Hello from INDIA");

            List<Employee> empList = new List<Employee>();



            empList.Add(new Employee { Name = "Marry", Id = 2, Experience = 5, Salary = 1202 });
            empList.Add(new Employee { Name = "Henry", Id = 3, Experience = 3, Salary = 20502 });
            empList.Add(new Employee { Name = "Deepak", Id = 4, Experience = 5, Salary = 125002 });
            empList.Add(new Employee { Name = "Muthu", Id = 5, Experience = 1, Salary = 10002 });

            IsPromotableDelegate promoteDele = new IsPromotableDelegate(PromoteBasedOnExp);
            Employee.PromoteEmployess(empList, promoteDele);
            ///  OR Using Lambda
            Employee.PromoteEmployess(empList, emp => emp.Salary>1000);

        }


        public static bool PromoteBasedOnExp(Employee emp)
        {
            if (emp.Experience > 3)
                return true;
            return false;
        }


        public static bool PromoteBasedOnSalary(Employee emp)
        {
            if (emp.Salary > 3)
                return true;
            return false;
        }
    }
}
