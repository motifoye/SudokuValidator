namespace SudokuTools
{
    public class SudokuConverter
    {
        public static int[][][][] Board2dTo4d(int[][] board)
        {
            const int F = 3;
            int[][][][] result =
                new[]
                {
                    new[]
                    {
                        new[]
                        {
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                        },
                        new[]
                        {
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                        },
                        new[]
                        {
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                        },
                    },
                    new[]
                    {
                        new[]
                        {
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                        },
                        new[]
                        {
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                        },
                        new[]
                        {
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                        },
                    },
                    new[]
                    {
                        new[]
                        {
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                        },
                        new[]
                        {
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                        },
                        new[]
                        {
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                            new[] { 0, 0, 0 },
                        },
                    },
                };

            for (int br = 0; br < F; br++)
                for (int fr = 0; fr < F; fr++)
                    for (int bc = 0; bc < F; bc++)
                        for (int fc = 0; fc < F; fc++)
                        {
                            result[br][bc][fr][fc] = board[(F-1) * br + br + fr][(F-1) * bc + bc + fc];
                        }

            return result;
        }
    }
}
