using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "aLLeN kUO";
            string upper = value.ToUpper();
            string lower = value.ToLower();
            string name1 = upper.Substring(0, 1);
            string name12 = lower.Substring(1, 5);
            string name2 = upper.Substring(6, 1);
            string name22 = lower.Substring(7);
            string answer = (name1 + name12 + name2 + name22);

            Console.WriteLine(answer);
        }
    }
}
