namespace SudokuTools
{
    public class SudokuValidator
    {
        private const int FINALSUM = 45;
        public static bool Validate(int[][] board)
        {
            for (int i = 0; i < board.Length - 1; i++)
                for (int j = 0; j < board[i].Length - 1; j++)
                    if (board[i][j] == 0 || board[i][j] == board[i][j + 1] || board[i][j] == board[i + 1][j]) return false;


            for (int i = 0; i < board.Length ; i++)
            {
                if (board[i].Sum() != FINALSUM)
                    return false;
            }

            for (int i = 0; i < board.Length - 1; i++)
            {
                int[] ints = new int[9];
                for (int j = 0; j < board[i].Length ; j++)
                {
                    ints[j] = board[j][i];
                }
                if (ints.Sum() != FINALSUM) return false;
            }

            var b4d = SudokuConverter.Board2dTo4d(board);
            for (int br = 0; br < 3; br++)
                for (int bc = 0; bc < 3; bc++)
                {
                    int[] ints = new int[9];
                    for (int fr = 0; fr < 3; fr++)
                    {
                        for (int fc = 0; fc < 3; fc++)
                        {
                            ints[(2 * fr) + fr + fc] = b4d[br][bc][fr][fc];
                        }
                    }
                    if(ints.Sum() != FINALSUM) return false;

                }

            return true;
        }

    }
}


/*

     0 1 2 | 3 4 5 | 6 7 8

     0       1       2
     ------+-------+------
0  0  1 2 3 | 4 5 6 | 7 8 9
1     1 2 3 | 4 5 6 | 7 8 9
2     1 2 3 | 4 5 6 | 7 8 9
-     ------+-------+------
3  1  1 2 3 | 4 5 6 | 7 8 9
4     1 2 3 | 4 5 6 | 7 8 9
5     1 2 3 | 4 5 6 | 7 8 9
-     ------+-------+------
6  2  1 2 3 | 4 5 6 | 7 8 9
7     1 2 3 | 4 5 6 | 7 8 9
8     1 2 3 | 4 5 6 | 7 8 9
     ------+-------+------

     0 1 2 | 3 4 5 | 6 7 8

     0       1       2
     ------+-------+------
0  0  1 2 3 | 4 5 6 | 7 8 9
1     7 8 9 | 1 2 3 | 4 5 6
2     4 5 6 | 7 8 9 | 1 2 3
-     ------+-------+------
3  1  2 3 4 | 5 6 7 | 8 9 1
4     8 9 1 | 2 3 4 | 5 6 7
5     5 6 7 | 8 9 1 | 2 3 4
-     ------+-------+------
6  2  3 4 5 | 6 7 8 | 9 1 2
7     9 1 2 | 3 4 5 | 6 7 8
8     6 7 8 | 9 1 2 | 3 4 5
     ------+-------+------

0 % 2 = 0
4 % 2 = 1



*/