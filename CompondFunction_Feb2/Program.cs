using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompondFunction_Feb2
{
    class Program
    {
        static void Main(string[] args)
        {
            double principal, n, rateOfIntrest,z;
            Console.WriteLine("enter the value p");
            principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the value n");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the value r");
            rateOfIntrest = Convert.ToDouble(Console.ReadLine());
            z=(principal *(1 + rateOfIntrest)/100);
            double result = Math.Pow(z, n);
            Console.WriteLine("result =" +result);


        }
    }
}
