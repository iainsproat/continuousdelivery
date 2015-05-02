using System;
using System.IO;
using NUnit.Framework;

namespace Test
{
	public static class Utilities
	{
		public const string relativeBaseDirectory = @"../../../../";
		
		public static string ReadFile(string fileName){
			try
			{
				using (var sr = new StreamReader(fileName))
				{
					String contents = sr.ReadToEnd();
					return contents;
				}
			}
			catch (Exception e)
			{
				Assert.Fail("Could not read file\n {0}", e.StackTrace);
				return string.Empty;
			}
			
		}
	}
}
