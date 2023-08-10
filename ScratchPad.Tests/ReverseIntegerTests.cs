namespace ScratchPad.Tests;

using ReverseInteger;

public class ReverseIntegerTests
{
    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    public void Reverse_HappyPath(int num, int expectedOutput)
    {
        var output = new Solution().Reverse(num);

        Assert.Equal(expectedOutput, output);
    }
}