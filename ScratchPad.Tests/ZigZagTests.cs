namespace ScratchPad.Tests;

using ZigZag;

public class ZigZagTests
{
    [Theory]
    [InlineData("121", 1, "121")]
    [InlineData("121", 2, "11\r\n2 ")]
    public void IsPalindrome_HappyPath(string s, int rows, string expectedOutput)
    {
        var output = new Solution().Convert(s, rows);

        Assert.Equal(expectedOutput, output);
    }
}