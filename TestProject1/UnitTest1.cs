using SudokuTools;

[TestFixture(Description = "Example tests")]
public class SudokuValidatorSampleTest
{

    private readonly (int[][], bool)[] fixedBoards = {
        (new []{
            new[]{5,5,5,5,5,5,5,5,5},
            new[]{5,5,5,5,5,5,5,5,5},
            new[]{5,5,5,5,5,5,5,5,5},
            new[]{5,5,5,5,5,5,5,5,5},
            new[]{5,5,5,5,5,5,5,5,5},
            new[]{5,5,5,5,5,5,5,5,5},
            new[]{5,5,5,5,5,5,5,5,5},
            new[]{5,5,5,5,5,5,5,5,5},
            new[]{5,5,5,5,5,5,5,5,5}}, false), // A board full of fives
        (new []{
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{1,2,3,4,5,6,7,8,9}}, false), // All rows are 1..9
        (new []{
            new[]{1,1,1,1,1,1,1,1,1},
            new[]{2,2,2,2,2,2,2,2,2},
            new[]{3,3,3,3,3,3,3,3,3},
            new[]{4,4,4,4,4,4,4,4,4},
            new[]{5,5,5,5,5,5,5,5,5},
            new[]{6,6,6,6,6,6,6,6,6},
            new[]{7,7,7,7,7,7,7,7,7},
            new[]{8,8,8,8,8,8,8,8,8},
            new[]{9,9,9,9,9,9,9,9,9}}, false),  // All cols are 1..9
        (new []{
            new[]{5,3,4,6,7,8,9,1,2},
            new[]{6,7,2,1,9,5,3,4,8},
            new[]{1,9,8,3,4,2,5,6,7},
            new[]{8,5,9,7,6,1,4,2,3},
            new[]{4,2,6,8,5,3,7,9,1},
            new[]{7,1,3,9,2,4,8,5,6},
            new[]{9,6,1,5,3,7,2,8,4},
            new[]{2,8,7,4,1,9,6,3,5},
            new[]{3,4,5,2,8,6,1,7,9}}, true),
        (new []{
            new[]{1,3,2,5,7,9,4,6,8},
            new[]{4,9,8,2,6,1,3,7,5},
            new[]{7,5,6,3,8,4,2,1,9},
            new[]{6,4,3,1,5,8,7,9,2},
            new[]{5,2,1,7,9,3,8,4,6},
            new[]{9,8,7,4,2,6,5,3,1},
            new[]{2,1,4,9,3,5,6,8,7},
            new[]{3,6,5,8,1,7,9,2,4},
            new[]{8,7,9,6,4,2,1,5,3}}, true),
        (new []{
            new[]{7,8,4,1,5,9,3,2,6},
            new[]{5,3,9,6,7,2,8,4,1},
            new[]{6,1,2,4,3,8,7,5,9},
            new[]{9,2,8,7,1,5,4,6,3},
            new[]{3,5,7,8,4,6,1,9,2},
            new[]{4,6,1,9,2,3,5,8,7},
            new[]{8,7,6,3,9,4,2,1,5},
            new[]{2,4,3,5,6,1,9,7,8},
            new[]{1,9,5,2,8,7,6,3,4}}, true),
        (new []{
            new[]{9,2,6,5,8,3,4,7,1},
            new[]{7,1,3,4,2,6,9,8,5},
            new[]{8,4,5,9,7,1,3,6,2},
            new[]{3,6,2,8,5,7,1,4,9},
            new[]{4,7,1,2,6,9,5,3,8},
            new[]{5,9,8,3,1,4,7,2,6},
            new[]{6,5,7,1,3,8,2,9,4},
            new[]{2,8,4,7,9,5,6,1,3},
            new[]{1,3,9,6,4,2,8,5,7}}, true),
        (new []{
            new[]{7,1,5,6,2,3,8,4,9},
            new[]{6,2,4,8,1,9,3,7,5},
            new[]{3,9,8,7,4,5,6,2,1},
            new[]{5,3,9,2,7,6,4,1,8},
            new[]{4,6,2,1,9,8,5,3,7},
            new[]{8,7,1,5,3,4,9,6,2},
            new[]{2,5,3,9,6,7,1,8,4},
            new[]{1,8,6,4,5,2,7,9,3},
            new[]{9,4,7,3,8,1,2,5,6}}, true),
        (new []{
            new[]{7,8,3,4,5,6,1,2,9},
            new[]{6,9,2,1,8,7,3,4,5},
            new[]{1,4,5,2,3,9,6,7,8},
            new[]{8,1,7,3,6,2,9,5,4},
            new[]{5,6,4,7,9,8,2,1,3},
            new[]{3,2,9,5,4,1,8,6,7},
            new[]{4,7,6,8,2,3,5,9,1},
            new[]{9,3,1,6,7,5,4,8,2},
            new[]{2,5,8,9,1,4,7,3,6}}, true),
        (new []{
            new[]{1,7,3,2,6,8,9,5,4},
            new[]{4,2,5,1,9,3,7,6,8},
            new[]{8,6,9,7,4,5,1,2,3},
            new[]{6,1,2,8,3,7,4,9,5},
            new[]{3,9,8,4,5,6,2,1,7},
            new[]{5,4,7,9,1,2,3,8,6},
            new[]{9,5,4,3,8,1,6,7,2},
            new[]{2,3,6,5,7,9,8,4,1},
            new[]{7,8,1,6,2,4,5,3,9}}, true),
        (new []{
            new[]{8,4,7,2,6,5,1,9,3},
            new[]{1,3,6,7,9,8,2,4,5},
            new[]{9,5,2,1,4,3,8,6,7},
            new[]{4,2,9,6,7,1,5,3,8},
            new[]{6,7,8,5,3,2,9,1,4},
            new[]{3,1,5,4,8,9,7,2,6},
            new[]{5,6,4,9,1,7,3,8,2},
            new[]{7,8,1,3,2,4,6,5,9},
            new[]{2,9,3,8,5,6,4,7,1}}, true),
        (new []{
            new[]{8,4,7,2,6,5,1,0,3},
            new[]{1,3,6,7,0,8,2,4,5},
            new[]{0,5,2,1,4,3,8,6,7},
            new[]{4,2,0,6,7,1,5,3,8},
            new[]{6,7,8,5,3,2,0,1,4},
            new[]{3,1,5,4,8,0,7,2,6},
            new[]{5,6,4,0,1,7,3,8,2},
            new[]{7,8,1,3,2,4,6,5,0},
            new[]{2,0,3,8,5,6,4,7,1}}, false), // a valid board, but with 0 instead of 9
        (new []{
            new[]{1,3,2,5,7,9,4,6,8},
            new[]{4,9,8,2,6,1,3,7,5},
            new[]{7,5,6,3,8,4,2,1,9},
            new[]{6,4,3,1,5,8,7,9,2},
            new[]{5,2,1,7,9,3,8,4,6},
            new[]{9,8,7,4,2,6,5,3,1},
            new[]{2,1,4,9,3,5,6,8,7},
            new[]{3,6,5,8,1,7,9,2,4},
            new[]{8,7,9,6,4,2,1,3,5}}, false), // duplicated '3' in eighth column
        (new []{
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{2,3,4,5,6,7,8,9,1},
            new[]{3,4,5,6,7,8,9,1,2},
            new[]{4,5,6,7,8,9,1,2,3},
            new[]{5,6,7,8,9,1,2,3,4},
            new[]{6,7,8,9,1,2,3,4,5},
            new[]{7,8,9,1,2,3,4,5,6},
            new[]{8,9,1,2,3,4,5,6,7},
            new[]{9,1,2,3,4,5,6,7,8}}, false), // valid rows and cols, but invalid boxes
        (new []{
            new[]{0,3,4,6,7,8,9,1,2},
            new[]{6,7,2,1,9,5,3,4,8},
            new[]{1,9,8,3,4,2,5,6,7},
            new[]{8,5,9,7,6,1,4,2,3},
            new[]{4,2,6,8,5,3,7,9,1},
            new[]{7,1,3,9,2,4,8,5,6},
            new[]{9,6,1,5,3,7,2,8,4},
            new[]{2,8,7,4,1,9,6,3,5},
            new[]{3,4,5,2,8,6,1,7,9}}, false),
        (new []{
            new[]{1,2,3,4,5,6,6,9,9},
            new[]{4,5,6,6,9,9,1,2,3},
            new[]{6,9,9,1,2,3,4,5,6},
            new[]{2,3,4,5,6,6,9,9,1},
            new[]{5,6,6,9,9,1,2,3,4},
            new[]{9,9,1,2,3,4,5,6,6},
            new[]{3,4,5,6,6,9,9,1,2},
            new[]{6,6,9,9,1,2,3,4,5},
            new[]{9,1,2,3,4,5,6,6,9}}, false),
        (new []{
            new[]{1,2,3,1,2,3,1,2,3},
            new[]{4,5,6,4,5,6,4,5,6},
            new[]{7,8,9,7,8,9,7,8,9},
            new[]{2,3,1,2,3,1,2,3,1},
            new[]{5,6,4,5,6,4,5,6,4},
            new[]{8,9,7,8,9,7,8,9,7},
            new[]{3,1,2,3,1,2,3,1,2},
            new[]{6,4,5,6,4,5,6,4,5},
            new[]{9,7,8,9,7,8,9,7,8}}, false),
        (new []{
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{4,5,6,7,8,9,1,2,3},
            new[]{7,8,9,1,2,3,4,5,6},
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{4,5,6,7,8,9,1,2,3},
            new[]{7,8,9,1,2,3,4,5,6},
            new[]{1,2,3,4,5,6,7,8,9},
            new[]{4,5,6,7,8,9,1,2,3},
            new[]{7,8,9,1,2,3,4,5,6}}, false)  // valid boxes and rows, repeats in cols
    };

    private int[][] Clone(int[][] board) => board.Select(row => row.ToArray()).ToArray();

    private string Stringify(int[][] board)
    {
        Func<int[], string> stringifyRow = row =>
                string.Join("", row[0..3]) + "|" +
                string.Join("", row[3..6]) + "|" +
                string.Join("", row[6..9]);
        List<string> rows = board.Select(stringifyRow).ToList();
        rows.Insert(6, "---+---+---");
        rows.Insert(3, "---+---+---");
        return string.Join("\n", rows);
    }

    [Test]
    public void FixedTests()
    {
        foreach (var (board, expected) in fixedBoards)
        {
            int[][] input = Clone(board);
            bool actual = SudokuValidator.Validate(input);
            Assert.That(actual, Is.EqualTo(expected), $"Incorrect answer for board:\n\n{Stringify(board)}\n");
            for (int rowNo = 0; rowNo < 9; ++rowNo)
            {
                CollectionAssert.AreEqual(input[rowNo], board[rowNo], "Input board must not be modified");
            }
        }
    }
}