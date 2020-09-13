
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EX_10
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = "input.txt";

            string txt = File.ReadAllText(path: path);

            // used regular expression pattern to match single characters in the character range a -z 
            Int64 count = Regex.Matches(txt, "([te])(?![a-z])", RegexOptions.Multiline | RegexOptions.IgnoreCase).Count;

            Console.Write($"This is the contents of the text file {path} \n");
            Console.WriteLine($"- {txt} -");

            Console.WriteLine($"\nThere are {count} words in the text file that end with a 't' or an 'e'.");
            Console.ReadLine();
        }
    }
}
