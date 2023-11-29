namespace tests.ben.Day09;

[TestClass]
public class PartOneTests
{
    /// <summary>
    /// The risk level of a low point is 1 plus its height. In the
    /// above example, the risk levels of the low points are 2, 1,
    /// 6, and 6. The sum of the risk levels of all low points in
    /// the heightmap is therefore 15.
    /// </summary>
    [TestMethod]
    public void RiskLevelOfALowPointIs1PlusItsHeight()
    {
        var height = 3;
        var riskLevel = BusinessLogicPartOne.CalculateRiskLevel(height);

        Assert.AreEqual(4, riskLevel);
    }
    
    [TestMethod]
    public void SinglePoint()
    {
        var data = new[] { 4 };
        var numberOfLowPoints = BusinessLogicPartOne.CountLowPoints(data);
        

        Assert.AreEqual(1, numberOfLowPoints);
    }

    /// <summary>
    /// I have two points, one of them is a low point.
    /// </summary>
    [TestMethod]
    public void CountLowPointsOfTwoPoints()
    {
        var data = new[] { 0, 1};
        var numberOfLowPoints = BusinessLogicPartOne.CountLowPoints(data);
        

        Assert.AreEqual(1, numberOfLowPoints);
    }

    /// <summary>
    /// I have an array of three data points, with two low points.
    /// </summary>
    [TestMethod]
    public void CountLowPointsInAnArrayOfThree()
    {
        var data = new[] { 0 , 3, 0};
        var numberOfLowPoints = BusinessLogicPartOne.CountLowPoints(data);
        

        Assert.AreEqual(2, numberOfLowPoints);
    }

    
    /// <summary>
    /// I have an array of three data points, with two low points.
    /// </summary>
    [TestMethod]
    public void IsLowPoint()
    {
        var data = new[] { 0 , 3, 0};
       // var numberOfLowPoints = 
         
       Assert.IsTrue(BusinessLogicPartOne.IsLowPoint(data, 0));
       Assert.IsFalse(BusinessLogicPartOne.IsLowPoint(data, 1));
       Assert.IsTrue(BusinessLogicPartOne.IsLowPoint(data, 2));
            
        
    }
}