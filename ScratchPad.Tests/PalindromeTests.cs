namespace ScratchPad.Tests;

using Palindrome;

public class PalindromeTests
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(1212, false)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void IsPalindrome_HappyPath(int num, bool isPalindrome)
    {
        var output = new Solution().IsPalindrome(num);

        Assert.Equal(isPalindrome, output);
    }
}