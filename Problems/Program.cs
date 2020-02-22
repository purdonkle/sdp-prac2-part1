using System;

namespace Problems
{
    public class Program
    {
		
		static void Main(string[] args)
		{
			Program program = new Program();
			program.Prefix(args[0]);
		}		

		public string Prefix(string input)
		{
			if (input == null)
			{
				return null;
			}			

			int lengthOfString = input.Length;
			int numberOfWords = input.Split(new char [0], StringSplitOptions.RemoveEmptyEntries).Length;
		
			string output = lengthOfString + "," + numberOfWords + ":" + input;
						
			return output;
		}
    }
}
