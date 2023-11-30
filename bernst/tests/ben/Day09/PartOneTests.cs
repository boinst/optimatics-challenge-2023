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
        var data = new[,] { { 4 } };
        var numberOfLowPoints = BusinessLogicPartOne.CountLowPoints(data);
        

        Assert.AreEqual(1, numberOfLowPoints);
    }

    /// <summary>
    /// I have two points, one of them is a low point.
    /// </summary>
    [TestMethod]
    public void CountLowPointsOfTwoPoints()
    {
        var data = new[,] {{ 0, 1 }};
        var numberOfLowPoints = BusinessLogicPartOne.CountLowPoints(data);
        

        Assert.AreEqual(1, numberOfLowPoints);
    }
    
    /// <summary>
    /// I have two points, one of them is a low point, but the
    /// array is vertical now.
    /// </summary>
    [TestMethod]
    public void CountLowPointsOfTwoPointsVertical()
    {
        var data = new[,]
        {
            { 0 }, 
            { 1 }
        };
        var numberOfLowPoints = BusinessLogicPartOne.CountLowPoints(data);
        

        Assert.AreEqual(1, numberOfLowPoints);
    }

    /// <summary>
    /// I have an array of three data points, with two low points.
    /// </summary>
    [TestMethod]
    public void CountLowPointsInAnArrayOfThree()
    {
        var data = new[,] {{ 0, 3, 0 }};
        var number_of_low_points = BusinessLogicPartOne.CountLowPoints(data);
        
        Assert.AreEqual(2, number_of_low_points);
    }
    
    [TestMethod]
    public void CountLowPointsInAnArrayOfThree2()
    {
        var data = new[,] {{ 3, 0, 3 }};
        var numberOfLowPoints = BusinessLogicPartOne.CountLowPoints(data);
        
        Assert.AreEqual(1, numberOfLowPoints);
    }

    
    /// <summary>
    /// I have an array of three data points, with two low points.
    /// </summary>
    [TestMethod]
    public void IsLowPoint1D()
    {
        // 
        var data = new[,] {{ 0 , 3, 0 }};


         
       Assert.IsTrue(BusinessLogicPartOne.IsLowPoint(data, new []{0, 0}));
       Assert.IsFalse(BusinessLogicPartOne.IsLowPoint(data, new []{1, 0}));
       Assert.IsTrue(BusinessLogicPartOne.IsLowPoint(data, new []{2, 0}));
    }

    [TestMethod]
    public void DimensionsOfArray()
    {
        var data = new[,] {{ 0, 3, 0 }};
        Assert.AreEqual(2, BusinessLogicPartOne.Max_X_Index(data));
        Assert.AreEqual(0, BusinessLogicPartOne.Max_Y_Index(data));
        Assert.AreEqual(3, BusinessLogicPartOne.Length_X(data));
        Assert.AreEqual(1, BusinessLogicPartOne.Length_Y(data));
    }
    
    /// <summary>
    /// I have an array of three data points, with two low points.
    /// </summary>
    [TestMethod]
    public void IsLowPoint2D()
    {
        var data = new[,] {
            { 0 , 3 }, 
            { 3, 0}
        };
         
        Assert.IsTrue(BusinessLogicPartOne.IsLowPoint(data, new[] { 0, 0 }));
        Assert.IsTrue(BusinessLogicPartOne.IsLowPoint(data, new[] { 1, 1 }));
        Assert.IsFalse(BusinessLogicPartOne.IsLowPoint(data, new[] { 1, 0 }));
    }

    [TestMethod]
    public void ParseInputDataSimple()
    {
        var parsed = BusinessLogicPartOne.ParseData("0");
        Assert.AreEqual(1, parsed.GetLength(0));
        Assert.AreEqual(1, parsed.GetLength(1));
        Assert.AreEqual(0, parsed[0,0]);
    }
    
    /// <summary>
    /// Two characters should parse to an array of two elements
    /// </summary>
    [TestMethod]
    public void ParseInputDataSimple2()
    {
        var parsed = BusinessLogicPartOne.ParseData("00");
        // y
        Assert.AreEqual(1, parsed.GetLength(0)); 

        // x
        Assert.AreEqual(2, parsed.GetLength(1));
    }
    /// <summary>
    /// Two characters should parse to an array of two elements
    /// </summary>
    [TestMethod]
    public void ParseInputDataSimpleTwoLines()
    {
        var parsed = BusinessLogicPartOne.ParseData("000\r\n111");
        // y
        Assert.AreEqual(2, parsed.GetLength(0)); 

        // x
        Assert.AreEqual(3, parsed.GetLength(1));
        
        // check the first and last values
        Assert.AreEqual(0, parsed[0,0]);
        Assert.AreEqual(1, parsed[1,2]);
    }

    /// <summary>
    /// Count the low points in the data set.
    /// </summary>
    [TestMethod]
    public void Count_low_points()
    {
        var parsed = BusinessLogicPartOne.ParseData(TestData.ExampleData);
        Assert.AreEqual(4, BusinessLogicPartOne.CountLowPoints(parsed));
    }

    /// <summary>
    /// Calculate the sum of risk levels across the height map, given example data.
    /// </summary>
    [TestMethod]
    public void sumOfRiskLevels()
    {
        var parsed = BusinessLogicPartOne.ParseData(TestData.ExampleData);
        Assert.AreEqual(15, BusinessLogicPartOne.SumOfRiskLevelOfAllLowPoints(parsed));
    }
}