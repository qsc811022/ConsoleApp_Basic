using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameList = {"張三","李四","王五"};
            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
