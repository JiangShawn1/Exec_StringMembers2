using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passWord = "Allen";
            Console.WriteLine("輸入ALLEN，不拘大小寫");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("您沒有輸入呀");
                return;
            }
            if(passWord.ToLower() == input.ToLower())
            {
                Console.WriteLine("輸入正確");
            }
            else
            {
                Console.WriteLine("輸入有誤");
            }
        }
    }
}
