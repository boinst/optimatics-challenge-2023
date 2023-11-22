namespace tests;

[TestClass]
public class InputDataTests
{
    [TestMethod]
    public void ParseInputData()
    {
        var startData = "3,4,3,1,2";

        var parsed = new tests.InputDataParser().Parse(startData);

        var expected = new[] { 3, 4, 3, 1, 2 };

        CollectionAssert.AreEqual(expected, parsed);
    }
}
