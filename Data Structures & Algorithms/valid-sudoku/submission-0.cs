public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        var rows = new Dictionary<int, HashSet<char>>();
        var cols = new Dictionary<int, HashSet<char>>();
        var squares = new Dictionary<string, HashSet<char>>();

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                if (board[r][c]=='.')
                {
                    continue;
                }
                var squareKey = (r/3) + "," + (c/3);

                var value = board[r][c];

                if((rows.ContainsKey(r) && rows[r].Contains(value)) ||
                    cols.ContainsKey(c) && cols[c].Contains(value) ||
                    squares.ContainsKey(squareKey) && squares[squareKey].Contains(value))
                    {
                        return false;
                    }
                if (!rows.ContainsKey(r)) rows[r] = new HashSet<char>();
                if (!cols.ContainsKey(c)) cols[c] = new HashSet<char>();
                if(!squares.ContainsKey(squareKey)) squares[squareKey] = new HashSet<char>();

                rows[r].Add(value);
                cols[c].Add(value);
                squares[squareKey].Add(value);
            }
        }

        return true;
    }
}
