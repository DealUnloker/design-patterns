using System;
using System.Collections;

namespace LB_7
{
    public class PowerList
    {
        public IEnumerable Power(int number, int exponent)
        {
            int valueCounter = 0;
            int currentResult = 1;
            while (valueCounter++ < exponent)
            {
                currentResult = currentResult * number;
                yield return currentResult;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PowerList demoObj = new PowerList();

            foreach (var value in demoObj.Power(2, 10))
            {
                Console.Write("{0}", value);
            }
            Console.ReadKey(true);
        }
    }
}
