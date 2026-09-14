public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {

        for (int i = 0; i < 9; i++)
        {
            int[] rows=new int[9];
            int[] cols =new int[9];
            int[] box = new int[9];
            for (int j = 0; j < 9; j++)
            {
                int row=1<<(board[i][j]-'1');
                int col=1<<(board[j][i]-'1');

                if (board[i][j] != '.' && (rows[i] & row) != 0) return false;
                rows[i] |= row;

                if (board[j][i] != '.' && (cols[i] & col) != 0) return false;
                cols[i] |= col;

                int boxRow = 3 * (i / 3) + j / 3;
                int boxCol = 3 * (i % 3) + j % 3;

                if (board[boxRow][boxCol] != '.' && (box[i] & (1 << (board[boxRow][boxCol] - '1'))) != 0) return false;
                box[i] |= 1 << (board[boxRow][boxCol] - '1');

            }
            
            
        }

        return true;
    }
}
