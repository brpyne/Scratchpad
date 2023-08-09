namespace Palindrome;

public class Solution {
    public bool IsPalindrome(int x) {
        
        var stack = new Stack<char>();
        
        var chars = x.ToString().ToCharArray();
        var charsReverse = x.ToString().ToCharArray();
        Array.Reverse<char>(charsReverse);

        for(int i = 0; i < chars.Count(); i++)
        {
            stack.Push(charsReverse[i]);

            if(chars[i] == charsReverse[i])
            {
                stack.Pop();
            }
        }

        return stack.Count == 0;
    }
}