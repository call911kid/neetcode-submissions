public class Solution
{
    List<List<string>> ls = new();
    public List<List<string>> SolveNQueens(int n)
    {
        bool[][] board = Enumerable.Range(0, n)
            .Select(_ => new bool[n])
            .ToArray();

        BackTrack(0, n, board,
            new HashSet<int>(),
            new HashSet<int>(),
            new HashSet<int>(),
            new HashSet<int>()
            );

        return ls;
    }

    private void BackTrack(int i, int n, bool[][] board,
        HashSet<int> rows,
        HashSet<int> cols,
        HashSet<int> digL,
        HashSet<int> digR)
    {
        if (i == n)
        {
            ls.Add(board
            .Select(row => string.Concat(row.Select(x => x ? 'Q' : '.')))
            .ToList()
            );

            return;
        }

        for(int j= 0; j < n; j++)
        {
            if (rows.Contains(i) || cols.Contains(j) || digL.Contains(i + j) || digR.Contains(i - j)) continue;
            
            rows.Add(i);
            cols.Add(j);
            digL.Add(i + j);
            digR.Add(i - j);
            board[i][j] = true;

            BackTrack(i+1, n, board, rows, cols, digL, digR);

            rows.Remove(i);
            cols.Remove(j);
            digL.Remove(i + j);
            digR.Remove(i - j);
            board[i][j] = false;


        }
        
        
    }
    
}
