namespace ScratchPad.Tests;

using ZigZag;

public class ZigZagTests
{
    [Theory]
    [InlineData("121", 1, "121")]
    [InlineData("AB", 3, "AB")]
    [InlineData("ABC", 2, "ACB")]
    [InlineData("123456", 3, "152463")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    public void Convert_HappyPath(string s, int rows, string expectedOutput)
    {
        var output = new Solution().Convert(s, rows);

        Assert.Equal(expectedOutput, output);
    }
} 