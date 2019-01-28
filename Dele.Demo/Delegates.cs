using System;


namespace Dele.Demo
{
    public delegate void HelloFunctionDelegate(string message);
    public class Delegate
    {  
        public static void hello(string strMesg)
        {
                Console.WriteLine(strMesg);
        }
       

    }
}
