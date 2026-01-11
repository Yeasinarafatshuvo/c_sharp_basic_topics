using System;
using System.Numerics;

namespace CSharpBasic
{
    class Practice
    {
        public static void Run()
        {
            try
            {
               int divisor = 0;
               int result = 10 / divisor;
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    
    }

    

    
}