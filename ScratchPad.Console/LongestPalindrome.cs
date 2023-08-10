namespace LongestPalindrome;

public class Solution {
    public string LongestPalindrome(string s) {
        string currentLongest = string.Empty;
        for(int i = 0; i < s.Length; i++)
        {
            for(int length = s.Length - i; length  > 0; length--)
            {
                var substring = s.Substring(i, length);
                if((substring.Length > currentLongest.Length) && IsPalindrome(substring))
                {
                    Console.WriteLine("Palindrome Check: " + substring);
                    if(substring.Length > currentLongest.Length)
                    {
                        currentLongest = substring;
                    }
                    
                    break;
                }
            }
        }

        return currentLongest;
    }

    public bool IsPalindrome(string s) {
        
        int left = 0;
        int right = s.Length - 1;

        while(left < right)
        {
            if(!s[left].Equals(s[right]))
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}