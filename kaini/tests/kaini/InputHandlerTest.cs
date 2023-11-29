namespace tests;

[TestClass]
public class InputHandlerTest : code.InputHandler
{
    [TestMethod]
    public void readInputTest()
    {
        string input =
        @"123
456
789";
        int[,] expected = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] actual = code.InputHandler.readInput(input);
        CollectionAssert.AreEqual(expected, actual);
    }
}
