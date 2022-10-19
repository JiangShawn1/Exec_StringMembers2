using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {//計算兩數之和，並指呈現小數兩位數
            Console.WriteLine("請輸入數字1:");
            string input1 = Console.ReadLine();
            Console.WriteLine("請輸入數字2:");
            string input2 = Console.ReadLine();

            double do1 =Convert.ToDouble(input1);
            double do2 =Convert.ToDouble(input2);

            double answer = do1 + do2;
            string answer1=answer.ToString("#.00");



            Console.WriteLine(answer1);
            

        }
    }
}
