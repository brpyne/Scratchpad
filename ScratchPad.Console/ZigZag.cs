namespace ZigZag;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if(numRows <= 1 || s.Length <= 1)
        {
            return s;
        }

        // use 2d array of chars
        // rows = param
        // columns = (rows / n) + (rows % n)
        // d = row - 2

        // loop columns
        // if hit row=max
        //traverse diagnol
        //if hit row=0
        // break
        var n = s.Length;
        int numColumns = (numRows / n) + (numRows % n);
        int numDiagnol = n - 2;
        var resultGrid = new char[numRows, numColumns];

        for(int x = 0; x < numColumns; x++)
            for(int y = 0; y < numRows; y++)
                if(x == numColumns)
                    resultGrid[x,y] =  new char();
                else
                    resultGrid[x,y] = ' ';

        int index = 0;
        int column = 0;
        while (index < n - 1)
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



        string output = string.Empty;
        for (int x = 0; x < resultGrid.GetLength(0); x++)
        {
            for (int y = 0; y < resultGrid.GetLength(1); y++)
                output += resultGrid[x, y];

            output += Environment.NewLine;
        }

        return output;
    }
}