using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "1100225";
            string year = value.Substring(0, 3);
            string monthDay = value.Substring(3);            
            int yearNumber = Convert.ToInt32(year);
            yearNumber += 1911;

            string answer=$"{yearNumber}{monthDay}";
            Console.WriteLine(answer);



        }
    }
}
