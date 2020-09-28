using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using System.Collections.Generic;

namespace UnitTestProject2
{
	[TestClass]
	public class UnitTest1
	{

		public static IEnumerable<object[]> DataProblem1
		{
			get
			{
				yield return new object[] { "{}", true };
				yield return new object[] { "}{", false };
				yield return new object[] { "{{}", false };
				yield return new object[] { "\"\"", true };
				yield return new object[] { "{{{}}}", true };
				yield return new object[] { "{}{{}}", true };
				yield return new object[] { "for (var i = 0; i < toScan.Length; i++) { if (toScan[i] == '}') { if (open <= 0) { return false; } else open--; } else if (toScan[i] == '{') { open++; } }", true };
			}
		}

		[DataTestMethod]
		[DynamicData(nameof(DataProblem1), DynamicDataSourceType.Property)]
		public void Problem1(string toScan, bool result)
		{
			// Arrange
			bool toAssert;
			//Act
			toAssert = ConsoleApp2.Program.problem1OpenCloseScan(toScan);
			//Assert
			Assert.AreEqual(toAssert, result);
		}

		public static IEnumerable<object[]> DataProblem2
		{
			get
			{
				yield return new object[] { new List<int> { 3, 5 }, 1000, 233168 };
				yield return new object[] { new List<int> { 2, 3, 5 }, 1000, 366832 };
			}
		}

		[DataTestMethod]
		[DynamicData(nameof(DataProblem2), DynamicDataSourceType.Property)]
		public void Problem2(List<int> toScan, int range, int result)
		{
			// Arrange

			//Act
			var toAssert = ConsoleApp2.Program.problem2SumOfMultiples(toScan, range);
			//Assert
			Assert.AreEqual(toAssert, result);
		}

	}
}
