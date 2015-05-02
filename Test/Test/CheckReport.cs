using System;
using NUnit.Framework;

namespace Test
{
	[TestFixture]
	public class CheckReport
	{		
		[Test]
		public void DoesNotContainBanana()
		{
			const string fileName = Utilities.relativeBaseDirectory + @"Reports/Structural/SD Report.txt";
			string contents = Utilities.ReadFile(fileName);
			StringAssert.Contains("Structural report", contents, "Could not find file");
			StringAssert.DoesNotContain("banana", contents, "The document is not allowed to contain the word 'banana'");
		}
	}
}