using SudokuTools;

int[][][][] board = new[] // board
{
    // 0 row on board
    new[]
    {
        // 0 col in 0 row on board 
        new[]
        {
            new[]{1, 2, 3},
            new[]{7, 8, 9},
            new[]{4, 5, 6},
        },
        // 1 col in 0 row on board 
        new[]
        {
            new[]{4, 5, 6},
            new[]{1, 2, 3},
            new[]{7, 8, 9},
        },
        // 2 col in 0 row on board 
        new[]
        {
            new[]{7, 8, 9},
            new[]{4, 5, 6},
            new[]{1, 2, 3},
        }
    },
    // 1 row on board
    new[]
    {
        // 0 col in 1 row on board 
        new[]
        {
            new[]{2, 3, 4},
            new[]{8, 9, 1},
            new[]{5, 6, 7},
        },
        // 1 col in 1 row on board 
        new[]
        {
            new[]{5, 6, 7},
            new[]{2, 3, 4},
            new[]{8, 9, 1},
        },
        // 2 col in 1 row on board 
        new[]
        {
            new[]{8, 9, 1},
            new[]{5, 6, 7},
            new[]{2, 3, 4},
        }
    },
    // 2 row on board
    new[]
    {
        // 0 col in 2 row on board 
        new[]
        {
            new[]{3, 4, 5},
            new[]{9, 1, 2},
            new[]{6, 7, 8},
        },
        // 1 col in 2 row on board 
        new[]
        {
            new[]{6, 7, 8},
            new[]{3, 4, 5},
            new[]{9, 1, 2},
        },
        // 2 col in 2 row on board 
        new[]
        {
            new[] { 9, 1, 2 },
            new[] { 6, 7, 8 },
            new[] { 3, 4, 5 },
        },
    },
};

Console.WriteLine(board[1][2][0][1]); // 9
Console.WriteLine();
int[][] a = new[]{
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{1,2,3,4,5,6,7,8,9}};
int[][] b = new[]{
            new[]{1,1,1,1,1,1,1,1,1},
            new[]{2,2,2,2,2,2,2,2,2},
            new[]{3,3,3,3,3,3,3,3,3},
            new[]{4,4,4,4,4,4,4,4,4},
            new[]{5,5,5,5,5,5,5,5,5},
            new[]{6,6,6,6,6,6,6,6,6},
            new[]{7,7,7,7,7,7,7,7,7},
            new[]{8,8,8,8,8,8,8,8,8},
            new[]{9,9,9,9,9,9,9,9,9}};
int[][] c = new[]{
            new[]{5,3,4,6,7,8,9,1,2},
            new[]{6,7,2,1,9,5,3,4,8},
            new[]{1,9,8,3,4,2,5,6,7},
            new[]{8,5,9,7,6,1,4,2,3},
            new[]{4,2,6,8,5,3,7,9,1},
            new[]{7,1,3,9,2,4,8,5,6},
            new[]{9,6,1,5,3,7,2,8,4},
            new[]{2,8,7,4,1,9,6,3,5},
            new[]{3,4,5,2,8,6,1,7,9}};
SudokuPrinter.Board4dToConsole(SudokuConverter.Board2dTo4d(a));
SudokuPrinter.Board4dToConsole(SudokuConverter.Board2dTo4d(b));
Console.WriteLine(SudokuValidator.Validate(a));
Console.WriteLine(SudokuValidator.Validate(b));
Console.WriteLine(SudokuValidator.Validate(c));
