using System;

namespace Delegates.Demo
{


    public delegate void HelloFunctionDelegate(string message);
    public class Delegates
    {
        public static void hello(string strMesg)
        {
Console.WriteLine(strMesg);



        }
    }
}
