namespace SudokuTools
{
    public class SudokuPrinter
    {
        public static void Board4dToConsole(int[][][][] board)
        {
            for (int br = 0; br < 3; br++)
            {
                for (int fr = 0; fr < 3; fr++)
                {
                    for (int bc = 0; bc < 3; bc++)
                    {
                        for (int fc = 0; fc < 3; fc++)
                        {
                            Console.Write(String.Format("{0,-2}", board[br][bc][fr][fc]));
                        }
                        if (bc < 3 - 1) Console.Write("| ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}