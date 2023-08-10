namespace ZigZag;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if(numRows <= 1 || numRows > s.Length || s.Length <= 1)
        {
            return s;
        }

        var n = s.Length;
        int numDiagnol = (numRows - 2) < 0 ? 0 : (numRows - 2);
        int numColumns = (n / numRows) + numDiagnol * (n / numRows);

        if(numDiagnol == 0)
        {
            numColumns+=(n/numRows);
        }

        var resultGrid = new char[numRows, numColumns];

        int index = 0;
        int column = 0;
        while (index < n)
        {
            // columns
            for (int r = 0; r < numRows; r++)
            {
                if(index != n)
                {
                    resultGrid[r, column] = s[index];
                    index++;
                }

                if (r == numRows - 1)
                {
                    break;
                }
            }

            if(column < numColumns - 1)
                column++;
            
            // diagnols
            if(numDiagnol > 0)
            {
                for (int i = numRows - 2; i > 0; i--)
                {

                    if(index != n)
                    {
                        resultGrid[i, column] = s[index];
                        index++;
                    }
                }

                if(column < numColumns - 1)
                    column++;
            }
        }

        string output = string.Empty;
        for (int x = 0; x < resultGrid.GetLength(0); x++)
        {
            for (int y = 0; y < resultGrid.GetLength(1); y++)
                if(resultGrid[x,y] != '\0')
                    output += resultGrid[x, y];
        }
        
        return output.Trim();
    }
}