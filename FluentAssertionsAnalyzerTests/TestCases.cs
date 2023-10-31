using FluentAssertions;

namespace FluentAssertionsAnalyzerTests;

[TestClass]
public class TestCases {
	[TestMethod]
	public void IsSquareBracketsRequired() {
		var a = () => 2;
		var b = () => 2;

		Assert.IsTrue(a() + b() == 4);

		// On commit 57bb1cadda787d087d0345942dce8b79a15fdc17
		// 'Simplify Assertion' makes invalid code for that case:
		// a() + b() == 4.Should().BeTrue();
		// Instead of expected:
		// (a() + b() == 4).Should().BeTrue();
	}
}