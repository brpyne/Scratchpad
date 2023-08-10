namespace ZigZag;

public class Solution
{
    public string Convert(string s, int numRows)
    {
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
        var resultGrid = new char[numColumns, numRows];

        int index = 0;
        int column = 0;
        while (index < n - 1)
        {
            // columns
            for (int r = 0; r < numRows; r++)
            {
                if(index != n)
                {
                    resultGrid[column, r] = s[index];
                    index++;
                }

                if (r == numRows - 1)
                {
                    Console.WriteLine("d");
                    break;
                }

            }

            // diagnols
            for (int i = numRows - 2; i > 0; i--)
            {
                column++;

                if(index != n)
                {
                    resultGrid[column, i] = s[index];
                    index++;
                }
            }
        }



        string output = string.Empty;
        for (int k = 0; k < resultGrid.GetLength(1); k++)
        {
            for (int l = 0; l < resultGrid.GetLength(0); l++)
                output += resultGrid[k, l];

            output += Environment.NewLine;
        }

        return output;
    }
}