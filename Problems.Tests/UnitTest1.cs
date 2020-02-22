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

      	[Test]
        public void test8i()
        {
			Program program = new Program();
            Assert.AreEqual(program.Prefix("hello"), "5,1:hello");
        }
		
		[Test]	
		public void test8ii()
		{
			Program program = new Program();
			Assert.AreEqual(program.Prefix(""), "0,0:");
		}

		[Test]
		public void test8iii()
		{
			Program program = new Program();
			Assert.AreEqual(program.Prefix("what    ...  did you say?? "), "27,5:what    ...  did you say?? ");
		}
    }
}
