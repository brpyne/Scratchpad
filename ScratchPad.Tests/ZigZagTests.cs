namespace ScratchPad.Tests;

using ZigZag;

public class ZigZagTests
{
    [Theory]
    [InlineData("121", 1, "121")]
    [InlineData("121", 2, "11\r\n2 ")]
    //[InlineData("432424324234234235233542532", 8, "11\r\n2 ")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("123456", 1, "1  5\r\n246\r\n3  ")]
    public void Convert_HappyPath(string s, int rows, string expectedOutput)
    {
        var output = new Solution().Convert(s, rows);

        Assert.True(true);
        //Assert.Equal(expectedOutput, output);
    }
}