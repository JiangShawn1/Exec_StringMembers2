using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入手機號碼");
            string number = Console.ReadLine();

            string snumber=number.Substring(0,4)+ new string('*',4)+number.Substring(8,2); 
            Console.WriteLine(snumber);
        }
    }
}
