namespace ReverseInteger;

public class Solution {
    public int Reverse(int x) {
        
        if(x > Int32.MaxValue || x < Int32.MinValue)
            return x;
        
        var str = x.ToString().ToCharArray();
        
        if(x < 0)
        {
            string y = x.ToString();
            str = y.Substring(1, y.Length - 1).ToCharArray();
        }     

        Array.Reverse(str);

        int retVal = 0;
        Int32.TryParse(str, out retVal);

        if(x < 0)
        {
            retVal *= -1;
        }

        return retVal;
    }
}