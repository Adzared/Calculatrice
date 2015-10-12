using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] delimiterChars = { '(', ')', '*', '/', '+', '-' };
            char[] delimiterChars = { '*', '/' };
            
            string text = "(1+2) + 3*8 + 3 / 5";
            string[] words = text.Split(delimiterChars);

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }
    }
}
