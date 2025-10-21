using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUGASS_2_XPPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int total = 0;

            while (i <= 5)
            {
                total += i;
                i++;
            }
            Console.WriteLine("total = " + total);
        }
    }
}
