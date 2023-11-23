namespace tests.ben.Common;

[TestClass]
public class InputDataTests
{
    [TestMethod]
    public void ParseInputData()
    {
        var start_data = "3,4,3,1,2";

        var parsed = new InputDataParser().Parse(start_data);

        var expected = new[] { 3, 4, 3, 1, 2 };

        CollectionAssert.AreEqual(expected, parsed);
    }
}
