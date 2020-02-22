using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

      	[TestCase("hello", "5,1:hello")]
		[TestCase("", "0,0:")]
		[TestCase("what    ...  did you say?? ", "27,5:what    ...  did you say?? ")]
		[TestCase("This is a six worded sentance", "29,6:This is a six worded sentance")]
		[TestCase("   hello    adam     ", "21,2:   hello    adam     ")]
		[TestCase(null, null)]
        public void test8i(string input, string output)
        {
			Program program = new Program();
            Assert.AreEqual(program.Prefix(input), output);
        }
    }
}
