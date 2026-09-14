public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {

        for (int i = 0; i < 9; i++)
        {
            bool ok = true;
            HashSet<char> rows = new HashSet<char>();
            HashSet<char> cols = new HashSet<char>();
            HashSet<char> boxSet = new HashSet<char>();
            for (int j = 0; j < 9; j++)
            {


                if (board[i][j] != '.' && !rows.Add(board[i][j])) ok = false;

                if (board[j][i] != '.' && !cols.Add(board[j][i])) ok = false;

                int boxRow = 3 * (i / 3) + j / 3;
                int boxCol = 3 * (i % 3) + j % 3;

                if (board[boxRow][boxCol] != '.' && !boxSet.Add(board[boxRow][boxCol])) ok = false;

                if (!ok)
                {
                    return false;
                }

            }
            
            if (!ok)
            {
                return false;
            }
        }

        return true;
    }
}
