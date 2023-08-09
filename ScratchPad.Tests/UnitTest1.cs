namespace ScratchPad.Tests;

using Solution;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var output = Solution.TestMe();

        Assert.Equal("yay", output);
    }
}