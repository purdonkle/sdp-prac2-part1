using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(Prefix(args[0]));
        }

		static string Prefix(string input)
		{
			int lengthOfString = input.Length;
			int numberOfWords = input.Split(new char [0], StringSplitOptions.RemoveEmptyEntries).Length;
		
			string output = lengthOfString + "," + numberOfWords + ":" + input;
						
			return output;
		}
    }
}
