using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AimaTeam.Extension;

namespace AimaTeam.Extension_ConsoleApp_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var base64_test_String = "hello,world";
            var base64_Result = base64_test_String.ToBase64String();            
            Console.Write(base64_Result);
            Console.ReadLine();
        }
    }
}
